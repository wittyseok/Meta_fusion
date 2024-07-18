using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Metafusion.PatientListItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Metafusion
{
    public partial class PatientListControl : UserControl
    {
        private FlowLayoutPanel itemsPanel;

        public PatientListControl()
        {
            InitializeComponent();
            InitializeList();
        }
        private VScrollBar vScrollBar;
        private List<PatientListItem> theUCs;
        private void InitializeList()
        {
            itemsPanel = new FlowLayoutPanel();

            itemsPanel.Dock = DockStyle.Fill;
            //------------------------
            //implement virtual paging
            //------------------------

            //turn off autosize, autoscroll
            itemsPanel.AutoScroll = false;
            itemsPanel.AutoSize = false;

            //make FlowLayoutPanel itemsPanel double-buffered
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            itemsPanel, new object[] { true });

            // Initialize VScrollBar
            vScrollBar = new VScrollBar();
            vScrollBar.Height = itemsPanel.Height;
            vScrollBar.Dock = DockStyle.Right;
            vScrollBar.ValueChanged += vScrollBar_ValueChanged;
            vScrollBar.MouseDown += VScrollBar_MouseDown;
            vScrollBar.MouseUp += VScrollBar_MouseUp;

            // Add controls to the frame
            frame_items.Controls.Add(itemsPanel);
            frame_items.Controls.Add(vScrollBar);

            // Initialize the list of user controls
            theUCs = new List<PatientListItem>();

            icon_select_all.Click += DoSelectAll;
            icon_select_all.MouseDown += SelectAll_MouseDown;
            icon_select_all.MouseUp += SelectAll_MouseUp;

            // Add MouseWheel event handler
            itemsPanel.MouseWheel += ItemsPanel_MouseWheel;
        }

        private bool vscrollbar_valueChanging = false;
        private void VScrollBar_MouseDown(object sender, MouseEventArgs e)
        {
            vscrollbar_valueChanging = true;
        }
        private void VScrollBar_MouseUp(object sender, MouseEventArgs e)
        {
            vscrollbar_valueChanging = false;
            UpdateFlowLayoutPanel();
        }
        private void UpdateScrollBar()
        {
            if (theUCs.Count > 0)
            {
                float pageSize = frame_items.Height /
                                 (theUCs.First().Height + theUCs.First().Margin.Top + theUCs.First().Margin.Bottom);
                vScrollBar.Maximum = (int)(theUCs.Count * 4 / (pageSize));
                vScrollBar.LargeChange = 2;
                vScrollBar.SmallChange = 1;
                vScrollBar.Enabled = theUCs.Count > pageSize;
            }
            else
            {
                vScrollBar.Maximum = 0;
                vScrollBar.Enabled = false;
            }
        }
        private void ItemsPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            int newValue = vScrollBar.Value - (e.Delta / SystemInformation.MouseWheelScrollDelta) * vScrollBar.SmallChange;
            vScrollBar.Value = Math.Max(vScrollBar.Minimum, Math.Min(vScrollBar.Maximum, newValue));
            UpdateFlowLayoutPanel();
        }

        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if (vscrollbar_valueChanging)
                return;

            UpdateFlowLayoutPanel();
        }

        private void UpdateFlowLayoutPanel()
        {
            if (theUCs.Count == 0) return;

            int pageSize = frame_items.Height / (theUCs.First().Height + theUCs.First().Margin.Top + theUCs.First().Margin.Bottom);

            int startIndex = Math.Min(theUCs.Count - 1, vScrollBar.Value);

            itemsPanel.SuspendLayout();
            itemsPanel.Controls.Clear();
            itemsPanel.Controls.AddRange(theUCs.Skip((startIndex-1)*pageSize/4).Take(pageSize+1).ToArray());
            itemsPanel.ResumeLayout();
        }
        public void ScrollTo(int item)
        {
            if (theUCs.Count == 0) return;

            int pageSize = frame_items.Height / (theUCs.First().Height + theUCs.First().Margin.Top + theUCs.First().Margin.Bottom);
            int p = item / pageSize;
            vScrollBar.Value = Math.Min(p, vScrollBar.Maximum);
        }
        public void SetItemList(List<PatientListItem> itemList)
        {
            itemsPanel.Controls.Clear();
            theUCs.Clear();
            theUCs.AddRange(itemList);

            Task.Run(() => ConnectItemSignal(itemList));

            UpdateScrollBar();
            UpdateFlowLayoutPanel();
        }


        public event EventHandler<PatientListItem.ItemClickedEventArgs> ItemClicked;
        private void ItemsPanel_ItemClicked(object? sender, PatientListItem.ItemClickedEventArgs e)
        {
            ItemClicked?.Invoke(sender, e); // ItemClicked 이벤트를 전파
        }

        public void AddItem(string stage, string id, string name, string storage, string modality, string seriesDescription, string seriesDate, string seriesTime, string studyDescription, string studyDate)
        {
            PatientListItem newItem = new PatientListItem(stage, id, name, storage, modality, seriesDescription, seriesDate, seriesTime, studyDescription, studyDate);
            theUCs.Add(newItem);
            newItem.ItemClicked += ItemsPanel_ItemClicked;

            UpdateScrollBar();
            UpdateFlowLayoutPanel();
        }


        private async void ConnectItemSignal(List<PatientListItem> itemList)
        {
            foreach (PatientListItem item in itemList)
            {
                item.ItemClicked += ItemsPanel_ItemClicked;
            }
        }

        public void RemoveCheckedItem()
        {
            for (int i = theUCs.Count - 1; i >= 0; i--)
            {
                if (theUCs[i].is_checked)
                {
                    itemsPanel.Controls.Remove(theUCs[i]);
                    theUCs[i].Dispose(); // Dispose the item to release resources
                    theUCs.RemoveAt(i);
                }
            }

            UpdateScrollBar();
            UpdateFlowLayoutPanel();
        }

        public void SelectAll()
        {
            if (theUCs.Count == 0) return;

            int pageSize = frame_items.Height / (theUCs.First().Height + theUCs.First().Margin.Top + theUCs.First().Margin.Bottom);
            int startIndex = Math.Min(theUCs.Count, vScrollBar.Value);
            startIndex = Math.Max(0, (startIndex - 1) * pageSize / 4); // 0-based index
            int endIndex = Math.Min(startIndex + pageSize+1, theUCs.Count-1); // 끝 인덱스

            bool all_checked = true;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (!theUCs[i].is_checked && theUCs[i].stage == "ready")
                {
                    all_checked = false;
                    break; // 체크 해제된 아이템을 찾으면 루프 종료
                }
            }

            // 현재 페이지의 아이템 체크 상태 변경
            for (int i = startIndex; i < endIndex; i++)
            {
                theUCs[i].is_checked = !all_checked; // 상태 반전
            }

            UpdateFlowLayoutPanel();
        }

        public List<PatientListItem> LoadROIList()
        {
            return theUCs;
        }

        private void DoSelectAll(object? sender, EventArgs e)
        {
            this.SelectAll();
        }
        private void SelectAll_MouseDown(object? sender, EventArgs e)
        {
            bg_select_all.BackColor = Color.FromArgb(31, 186, 255);
        }
        private void SelectAll_MouseUp(object? sender, EventArgs e)
        {
            bg_select_all.BackColor = Color.FromArgb(240, 240, 244);
        }

        private void PatientListControl_SizeChanged(object sender, EventArgs e)
        {
            UpdateFlowLayoutPanel();
            UpdateScrollBar();
        }
    }
}
