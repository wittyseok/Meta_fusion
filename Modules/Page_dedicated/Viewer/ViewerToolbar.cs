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
    public partial class ViewerToolbar : UserControl
    {
        public event EventHandler<TabClickedEventArgs> TabClicked;
        private List<RoundedPanel> buttons;
        private List<PictureBox> pictures;
        private List<Image> picture_icons;
        private List<Image> picture_icons_activated;
        private int buttonActivatedIndex = -1;

        public int ButtonActivatedIndex
        {
            get => buttonActivatedIndex;
            set
            {
                if (buttonActivatedIndex != value)
                {
                    buttonActivatedIndex = value;
                    UpdateButtonColors();
                }
            }
        }

        public Color DeactivatedColor { get; set; } = Color.FromArgb(76, 76, 103);
        public Color ActivatedColor { get; set; } = Color.FromArgb(211, 211, 222);

        public ViewerToolbar()
        {
            InitializeComponent();
            InitializeToolbar();
        }
        public void InitializeToolbar()
        {
            // 각 버튼 클릭 이벤트를 연결
            button_viewer_cursor.Click += (s, e) => OnTabClicked("cursor", 0);
            button_viewer_grab.Click += (s, e) => OnTabClicked("grab", 1);
            button_viewer_zoom_in.Click += (s, e) => OnTabClicked("zoom_in", 2);
            button_viewer_adj_contrast.Click += (s, e) => OnTabClicked("contrast", 3);
            // 각 이미지 클릭 이벤트를 연결
            picture_viewer_cursor.Click += (s, e) => OnTabClicked("cursor", 0);
            picture_viewer_grab.Click += (s, e) => OnTabClicked("grab", 1);
            picture_viewer_zoom_in.Click += (s, e) => OnTabClicked("zoom_in", 2);
            picture_viewer_adj_contrast.Click += (s, e) => OnTabClicked("contrast", 3);

            // 버튼들을 컬렉션에 추가
            buttons = new List<RoundedPanel>
            {
                button_viewer_cursor,
                button_viewer_grab,
                button_viewer_zoom_in,
                button_viewer_adj_contrast
            };

            pictures = new List<PictureBox>
            {
                picture_viewer_cursor,
                picture_viewer_grab,
                picture_viewer_zoom_in,
                picture_viewer_adj_contrast
            };

            picture_icons = new List<Image>
            {
                Properties.Resources.icon_cursor,
                Properties.Resources.icon_grab,
                Properties.Resources.icon_zoom_in,
                Properties.Resources.icon_contrast
            };

            picture_icons_activated = new List<Image>
            {
                Properties.Resources.icon_curs_act,
                Properties.Resources.icon_grab_act,
                Properties.Resources.icon_zoom_in_act,
                Properties.Resources.icon_contrast_act
            };


        }
        protected virtual void OnTabClicked(string tabName, int index)
        {
            ButtonActivatedIndex = index;
            TabClicked?.Invoke(this, new TabClickedEventArgs(tabName));
        }
        private void UpdateButtonColors()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (i == ButtonActivatedIndex)
                {
                    buttons[i].BackColor = ActivatedColor;  // 활성화된 버튼의 색상
                    buttons[i].BorderWidth = 0;
                    pictures[i].Image = picture_icons_activated[i];
                }
                else
                {
                    buttons[i].BackColor = DeactivatedColor;  // 비활성화된 버튼의 기본 색상
                    buttons[i].BorderWidth = 1;
                    pictures[i].Image = picture_icons[i];
                }
            }
        }

        public class TabClickedEventArgs : EventArgs
        {
            public string TabName { get; }

            public TabClickedEventArgs(string tabName)
            {
                TabName = tabName;
            }
        }

        private void label_viewer_tools_Click(object sender, EventArgs e)
        {

        }

        private void frame_viewer_tools_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
