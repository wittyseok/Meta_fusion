using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metafusion
{
    public partial class ROIListControl_Export : UserControl
    {
        private FlowLayoutPanel itemsPanel;
        private List<ROIListItem_Export> items;

        public ROIListControl_Export()
        {
            InitializeComponent();
            InitializeList();
            items = new List<ROIListItem_Export>();
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

        public void AddItem(bool is_checked, string name, Color color)
        {
            ROIListItem_Export newItem = new ROIListItem_Export(is_checked, name, color);
            itemsPanel.Controls.Add(newItem);
            items.Add(newItem);
        }

        public void SetItemList(List<ROIListItem_Export> itemList)
        {
            itemsPanel.Controls.AddRange(itemList.ToArray());
            for (int i = items.Count - 1; i >= 0; i--)
            {
                itemsPanel.Controls.Remove(items[i]);
                items[i].Dispose(); // Dispose the item to release resources
            }
            items = itemList;
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

        public List<ROIListItem_Export> LoadROIList()
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
