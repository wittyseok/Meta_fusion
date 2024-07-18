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
    public partial class DrawingToolbar : UserControl
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

        public DrawingToolbar()
        {
            InitializeComponent();
            InitializeToolbar();
        }

        public void InitializeToolbar()
        {
            // 각 버튼 클릭 이벤트를 연결
            button_brush.Click += (s, e) => OnTabClicked("brush", 0);
            button_contour.Click += (s, e) => OnTabClicked("contour", 1);
            button_fill.Click += (s, e) => OnTabClicked("fill", 2);
            button_rectangle.Click += (s, e) => OnTabClicked("rectangle", 3);
            // 각 이미지 클릭 이벤트를 연결
            picture_brush.Click += (s, e) => OnTabClicked("brush", 0);
            picture_contour.Click += (s, e) => OnTabClicked("contour", 1);
            picture_fill.Click += (s, e) => OnTabClicked("fill", 2);
            picture_rect.Click += (s, e) => OnTabClicked("rectangle", 3);

            // 버튼들을 컬렉션에 추가
            buttons = new List<RoundedPanel>
            {
                button_brush,
                button_contour,
                button_fill,
                button_rectangle
            };

            pictures = new List<PictureBox>
            {
                picture_brush,
                picture_contour,
                picture_fill,
                picture_rect
            };

            picture_icons = new List<Image>
            {
                Properties.Resources.icon_brush,
                Properties.Resources.icon_contour,
                Properties.Resources.icon_fill,
                Properties.Resources.icon_rect
            };

            picture_icons_activated = new List<Image>
            {
                Properties.Resources.icon_brush_act,
                Properties.Resources.icon_contour_act,
                Properties.Resources.icon_fill_act,
                Properties.Resources.icon_rect_act
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

        private void label_drawing_tools_Click(object sender, EventArgs e)
        {

        }
    }
}
