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
    public partial class IOToolbar : UserControl
    {
        public event EventHandler<TabClickedEventArgs> TabClicked;
        private List<RoundedPanel> buttons;
        private List<PictureBox> pictures;
        private List<Image> picture_icons;
        private List<Image> picture_icons_activated;

        public Color DeactivatedColor { get; set; } = Color.FromArgb(76, 76, 103);
        public Color ActivatedColor { get; set; } = Color.FromArgb(211, 211, 222);

        public IOToolbar()
        {
            InitializeComponent();
            InitializeToolbar();
        }

        public void InitializeToolbar()
        {
            // 각 버튼 클릭 이벤트를 연결
            button_io_save.Click += (s, e) => OnTabClicked("save", 0);
            button_io_export.Click += (s, e) => OnTabClicked("export", 1);
            // 각 이미지 클릭 이벤트를 연결
            picture_io_save.Click += (s, e) => OnTabClicked("save", 0);
            picture_io_export.Click += (s, e) => OnTabClicked("export", 1);

            // 각 버튼 초기화 및 이벤트 연결
            button_io_save.MouseDown += (s, e) => OnMouseDown("save", 0);
            button_io_export.MouseDown += (s, e) => OnMouseDown("export", 1);

            button_io_save.MouseUp += (s, e) => OnMouseUp("save", 0);
            button_io_export.MouseUp += (s, e) => OnMouseUp("export", 1);

            // 각 이미지 초기화 및 이벤트 연결
            picture_io_save.MouseDown += (s, e) => OnMouseDown("save", 0);
            picture_io_export.MouseDown += (s, e) => OnMouseDown("export", 1);

            picture_io_save.MouseUp += (s, e) => OnMouseUp("save", 0);
            picture_io_export.MouseUp += (s, e) => OnMouseUp("export", 1);

            buttons = new List<RoundedPanel>
            {
                button_io_save,
                button_io_export
            };

                        pictures = new List<PictureBox>
            {
                picture_io_save,
                picture_io_export
            };

                        picture_icons = new List<Image>
            {
                Properties.Resources.Viewer_Tool_Icons_save,
                Properties.Resources.Viewer_Tool_Icons_export
            };

                        picture_icons_activated = new List<Image>
            {
                Properties.Resources.icon_save_act,
                Properties.Resources.icon_export_act
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

        private void picture_io_save_Click(object sender, EventArgs e)
        {

        }

        public class TabClickedEventArgs : EventArgs
        {
            public string TabName { get; }

            public TabClickedEventArgs(string tabName)
            {
                TabName = tabName;
            }
        }

        private void label_io_tools_Click(object sender, EventArgs e)
        {

        }

        private void frame_io_tools_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
