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
    public partial class LeftToolbar : UserControl
    {
        public event EventHandler<TabClickedEventArgs> TabClicked;
        private List<RoundedPanel> buttons;
        private List<PictureBox> pictures;
        private List<Image> picture_icons;
        private List<Image> picture_icons_activated;

        public Color DeactivatedColor { get; set; } = Color.FromArgb(76, 76, 103);
        public Color ActivatedColor { get; set; } = Color.FromArgb(211, 211, 222);

        public LeftToolbar()
        {
            InitializeComponent();
            InitializeToolbar();
        }

        public void InitializeToolbar()
        {
            // 각 버튼 클릭 이벤트를 연결
            button_toggle.Click += (s, e) => OnTabClicked("toggle", 0);
            button_add.Click += (s, e) => OnTabClicked("add", 1);
            button_sub.Click += (s, e) => OnTabClicked("sub", 2);
            button_center.Click += (s, e) => OnTabClicked("center", 3);
            button_load.Click += (s, e) => OnTabClicked("load", 4);
            button_transfer.Click += (s, e) => OnTabClicked("transfer", 5);
            // 각 이미지 클릭 이벤트를 연결
            picture_toggle.Click += (s, e) => OnTabClicked("toggle", 0);
            picture_add.Click += (s, e) => OnTabClicked("add", 1);
            picture_sub.Click += (s, e) => OnTabClicked("sub", 2);
            picture_center.Click += (s, e) => OnTabClicked("center", 3);
            picture_load.Click += (s, e) => OnTabClicked("load", 4);
            picture_transfer.Click += (s, e) => OnTabClicked("transfer", 5);

            // 각 버튼 초기화 및 이벤트 연결
            button_toggle.MouseDown += (s, e) => OnMouseDown("toggle", 0);
            button_add.MouseDown += (s, e) => OnMouseDown("add", 1);
            button_sub.MouseDown += (s, e) => OnMouseDown("sub", 2);
            button_center.MouseDown += (s, e) => OnMouseDown("center", 3);
            button_load.MouseDown += (s, e) => OnMouseDown("load", 4);
            button_transfer.MouseDown += (s, e) => OnMouseDown("transfer", 5);

            button_toggle.MouseUp += (s, e) => OnMouseUp("toggle", 0);
            button_add.MouseUp += (s, e) => OnMouseUp("add", 1);
            button_sub.MouseUp += (s, e) => OnMouseUp("sub", 2);
            button_center.MouseUp += (s, e) => OnMouseUp("center", 3);
            button_load.MouseUp += (s, e) => OnMouseUp("load", 4);
            button_transfer.MouseUp += (s, e) => OnMouseUp("transfer", 5);

            // 각 이미지 초기화 및 이벤트 연결
            picture_toggle.MouseDown += (s, e) => OnMouseDown("toggle", 0);
            picture_add.MouseDown += (s, e) => OnMouseDown("add", 1);
            picture_sub.MouseDown += (s, e) => OnMouseDown("sub", 2);
            picture_center.MouseDown += (s, e) => OnMouseDown("center", 3);
            picture_load.MouseDown += (s, e) => OnMouseDown("load", 4);
            picture_transfer.MouseDown += (s, e) => OnMouseDown("transfer", 5);

            picture_toggle.MouseUp += (s, e) => OnMouseUp("toggle", 0);
            picture_add.MouseUp += (s, e) => OnMouseUp("add", 1);
            picture_sub.MouseUp += (s, e) => OnMouseUp("sub", 2);
            picture_center.MouseUp += (s, e) => OnMouseUp("center", 3);
            picture_load.MouseUp += (s, e) => OnMouseUp("load", 4);
            picture_transfer.MouseUp += (s, e) => OnMouseUp("transfer", 5);

            // 버튼들을 컬렉션에 추가
            buttons = new List<RoundedPanel>
            {
                button_toggle,
                button_add,
                button_sub,
                button_center,
                button_load,
                button_transfer
            };

            pictures = new List<PictureBox>
            {
                picture_toggle,
                picture_add,
                picture_sub,
                picture_center,
                picture_load,
                picture_transfer
            };

            picture_icons = new List<Image>
            {
                Properties.Resources.icon_toggle,
                Properties.Resources.icon_add,
                Properties.Resources.icon_sub,
                Properties.Resources.icon_center,
                Properties.Resources.icon_load,
                Properties.Resources.icon_transfer
            };

            picture_icons_activated = new List<Image>
            {
                Properties.Resources.icon_toggle_act,
                Properties.Resources.icon_add_act,
                Properties.Resources.icon_sub_act,
                Properties.Resources.icon_center_act,
                Properties.Resources.icon_load_act,
                Properties.Resources.icon_transfer_act
            };


        }

        protected virtual void OnTabClicked(string tabName, int index)
        {
            //ButtonActivatedIndex = index;
            TabClicked?.Invoke(this, new TabClickedEventArgs(tabName));
        }

        private void OnMouseDown(string tabName, int index)
        {
            buttons[index].BackColor = ActivatedColor;
            buttons[index].BorderWidth = 0;
            pictures[index].Image = picture_icons_activated[index];
        }

        private void OnMouseUp(string tabName, int index)
        {
            buttons[index].BackColor = DeactivatedColor;  // 비활성화된 버튼의 기본 색상
            buttons[index].BorderWidth = 1;
            pictures[index].Image = picture_icons[index];
        }

        public class TabClickedEventArgs : EventArgs
        {
            public string TabName { get; }

            public TabClickedEventArgs(string tabName)
            {
                TabName = tabName;
            }
        }

        private void picture_center_Click(object sender, EventArgs e)
        {

        }
    }
}
