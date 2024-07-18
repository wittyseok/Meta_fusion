using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Metafusion
{
    public partial class ROIListControl : UserControl
    {
        private FlowLayoutPanel itemsPanel;
        private List<ROIListItem> items;

        public ROIListControl()
        {
            InitializeComponent();
            InitializeList();
            items = new List<ROIListItem>();
        }

        private void InitializeList()
        {
            this.Dock = DockStyle.Fill;

            itemsPanel = new FlowLayoutPanel();
            itemsPanel.Dock = DockStyle.Fill;
            itemsPanel.AutoScroll = true; // 스크롤 지원

            frame_items.Controls.Add(itemsPanel);

            icon_select_all.Click += DoSelectAll;
            icon_select_all.MouseDown += SelectAll_MouseDown;
            icon_select_all.MouseUp += SelectAll_MouseUp;
        }

        public event EventHandler<ROIListItem.ItemClickedEventArgs> ItemClicked;
        private void ItemsPanel_ItemClicked(object? sender, ROIListItem.ItemClickedEventArgs e)
        {
            ItemClicked?.Invoke(sender, e); // ItemClicked 이벤트를 전파
        }

        public void AddItem(bool is_visible, bool is_checked, string name, Color color)
        {
            ROIListItem newItem = new ROIListItem(is_visible, is_checked, name, color);
            itemsPanel.Controls.Add(newItem);
            items.Add(newItem);

            newItem.ItemClicked += ItemsPanel_ItemClicked;
        }

        public void SetItemList(List<ROIListItem> itemList)
        {
            itemsPanel.Controls.AddRange(itemList.ToArray());
            for (int i = items.Count - 1; i >= 0; i--)
            {
                itemsPanel.Controls.Remove(items[i]);
                items[i].Dispose(); // Dispose the item to release resources
            }
            items = itemList;

            Task.Run(() => ConnectItemSignal(itemList));
        }
        private async void ConnectItemSignal(List<ROIListItem> itemList)
        {
            foreach (ROIListItem item in itemList)
            {
                item.ItemClicked += ItemsPanel_ItemClicked;
            }
        }

        public void RemoveCheckedItem()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (items[i].is_checked)
                {
                    itemsPanel.Controls.Remove(items[i]);
                    items[i].Dispose(); // Dispose the item to release resources
                    items.RemoveAt(i);
                }
            }
        }

        public void ToggleCheckedItem()
        {
            bool toggle_value = false;
            for (int i = 0; i <= items.Count - 1; i++)
            {
                if (items[i].is_checked)
                {
                    toggle_value = !items[i].is_visible;
                    break;
                }
            }
            for (int i = 0; i <= items.Count - 1; i++)
            {
                if (items[i].is_checked)
                {
                    items[i].is_visible = toggle_value;
                }
            }
        }

        public void SelectAll()
        {
            bool all_checked = true;
            for (int i = 0; i <= items.Count - 1; i++)
            {
                if (!items[i].is_checked) all_checked = false;
            }

            if (all_checked)
            {
                for (int i = 0; i <= items.Count - 1; i++)
                {
                    items[i].is_checked = false;
                }
            }
            else
            {
                for (int i = 0; i <= items.Count - 1; i++)
                {
                    items[i].is_checked = true;
                }
            }
        }

        public List<ROIListItem> LoadROIList()
        {
            return items;
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

        private void frame_items_Paint(object sender, PaintEventArgs e)
        {

        }

        public void relocateCheckBox(int x, int y)
        {
            bg_select_all.Location = new Point(x, y);
        }

        private void panel_select_all_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
