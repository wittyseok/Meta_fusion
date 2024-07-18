using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Metafusion
{
    public partial class NavBarUserControl : UserControl
    {
        private List<Panel> buttons;
        private List<Panel> button_downsides;
        private int buttonActivatedIndex;

        public event EventHandler<TabClickedEventArgs> TabClicked;

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

        public Color DeactivatedColor { get; set; } = Color.FromArgb(98, 98, 132);
        public Color DownsideDeactivatedColor { get; set; } = Color.FromArgb(62, 62, 84);
        public Color ActivatedColor { get; set; } = Color.FromArgb(33, 33, 44);
        public Color DownsideActivatedColor { get; set; } = Color.FromArgb(31, 186, 255);

        public NavBarUserControl()
        {
            InitializeComponent();
            InitializeNavBar();
        }

        private void InitializeNavBar()
        {
            // 버튼들을 컬렉션에 추가
            buttons = new List<Panel>
            {
                button_home,
                button_item1,
                button_item3,
                button_item5,
                button_itemtooth,
                button_viewer
            };

            button_downsides = new List<Panel>
            {
                panel_home,
                panel_item1,
                panel_item3,
                panel_item5,
                panel_itemtooth,
                panel_viewer
            };

            // 각 버튼 클릭 이벤트를 연결
            button_home.Click += (s, e) => OnTabClicked("home", 0);
            button_item1.Click += (s, e) => OnTabClicked("item1", 1);
            button_item3.Click += (s, e) => OnTabClicked("item3", 2);
            button_item5.Click += (s, e) => OnTabClicked("item5", 3);
            button_itemtooth.Click += (s, e) => OnTabClicked("itemtooth", 4);
            button_viewer.Click += (s, e) => OnTabClicked("viewer", 5);
            //각 레이블 클릭 이벤트 연결
            label_home.Click += (s, e) => OnTabClicked("home", 0);
            label_item1.Click += (s, e) => OnTabClicked("item1", 1);
            label_item3.Click += (s, e) => OnTabClicked("item3", 2);
            label_item5.Click += (s, e) => OnTabClicked("item5", 3);
            label_itemtooth.Click += (s, e) => OnTabClicked("itemtooth", 4);
            label_viewer.Click += (s, e) => OnTabClicked("viewer", 5);
            //각 버튼 아래부분 클릭 이벤트 연결
            panel_home.Click += (s, e) => OnTabClicked("home", 0);
            panel_item1.Click += (s, e) => OnTabClicked("item1", 1);
            panel_item3.Click += (s, e) => OnTabClicked("item3", 2);
            panel_item5.Click += (s, e) => OnTabClicked("item5", 3);
            panel_itemtooth.Click += (s, e) => OnTabClicked("itemtooth", 4);
            panel_viewer.Click += (s, e) => OnTabClicked("viewer", 5);



            // 초기 색상 업데이트
            UpdateButtonColors();
        }

        protected virtual void OnTabClicked(string tabName, int index)
        {
            if (LicenseManager.HasLicense(tabName))
            {
                //ButtonActivatedIndex = index;
                TabClicked?.Invoke(this, new TabClickedEventArgs(tabName));
            }
            else
            {
                //TODO: license 없을 경우 표시
                MessageBox.Show("No License!");
            }
        }

        private void UpdateButtonColors()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (i == ButtonActivatedIndex)
                {
                    buttons[i].BackColor = ActivatedColor;  // 활성화된 버튼의 색상
                    button_downsides[i].BackColor = DownsideActivatedColor;
                }
                else
                {
                    buttons[i].BackColor = DeactivatedColor;  // 비활성화된 버튼의 기본 색상
                    button_downsides[i].BackColor = DownsideDeactivatedColor;
                }
            }
        }

        private void label_home_Click(object sender, EventArgs e)
        {

        }

        private void button_item1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_item5_Click(object sender, EventArgs e)
        {

        }

        private void label_item1_Click(object sender, EventArgs e)
        {

        }

        private void label_itemtooth_Click(object sender, EventArgs e)
        {

        }

        private void button_item3_Paint(object sender, PaintEventArgs e)
        {

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
}
