using Metafusion.Properties;
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
    public partial class ROIListItem_Export : UserControl
    {
        private Label titleLabel;
        private bool _is_checked = true;
        public bool is_checked
        {
            get { return _is_checked; }
            set
            {
                _is_checked = value;
                if (is_checked)
                {
                    checkbox_bg.BackColor = Color.FromArgb(31, 186, 255);
                }
                else
                {
                    checkbox_bg.BackColor = Color.FromArgb(240, 240, 244);
                }
            }
        }
        public Color color { get; set; } = Color.Green;
        public string name { get; set; } = "";

        public ROIListItem_Export(bool is_checked, string name, Color color)
        {
            InitializeComponent();
            InitializeItem(is_checked, name, color);
            roi_name.DoubleClick += roi_name_DoubleClick; // 더블 클릭 이벤트 핸들러 추가
            roi_name.LostFocus += roi_name_LostFocus; // 포커스 잃었을 때 이벤트 핸들러 추가
        }

        private void InitializeItem(bool is_checked, string name, Color color)
        {
            this.color = color;
            this.name = name;
            this.is_checked = is_checked;

            roi_name.Text = this.name;
            roi_color.BackColor = this.color;

            if (is_checked)
            {
                checkbox_bg.BackColor = Color.FromArgb(31, 186, 255);
            }
            else
            {
                checkbox_bg.BackColor = Color.FromArgb(240, 240, 244);
            }
        }

        private void ROIListItem_Load(object sender, EventArgs e)
        {

        }

        private void icon_check_Click(object sender, EventArgs e)
        {
            is_checked = !is_checked;
        }

        private void roi_name_DoubleClick(object sender, EventArgs e)
        {
            roi_name.ReadOnly = false;
            roi_name.Cursor = Cursors.IBeam; // 커서가 보이도록 설정
            roi_name.BackColor = Color.White; // 수정 모드일 때 배경색 변경 (선택 사항)
            roi_name.ForeColor = Color.Black; // 수정 모드일 때 글자색 변경 (선택 사항)
        }

        private void roi_name_LostFocus(object sender, EventArgs e)
        {
            roi_name.ReadOnly = true;
            roi_name.Cursor = Cursors.Default; // 커서가 보이지 않도록 설정
            roi_name.BackColor = Color.FromArgb(33, 33, 44); // 원래 배경색으로 변경
            roi_name.ForeColor = Color.FromArgb(240, 240, 244); // 원래 글자색으로 변경
            name = roi_name.Text; // 이름 값 업데이트

            // 텍스트박스의 커서 숨기기
            if (Parent != null)
            {
                Parent.Focus();
            }
        }

        private void roi_name_Click(object sender, EventArgs e)
        {
            if (roi_name.ReadOnly)
            {
                // 텍스트박스의 커서 숨기기
                if (Parent != null)
                {
                    Parent.Focus();
                }
            }
        }

        private void roi_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // enter키
            {
                if (!roi_name.ReadOnly)
                {
                    roi_name.ReadOnly = true;
                    roi_name.Cursor = Cursors.Default; // 커서가 보이지 않도록 설정
                    roi_name.BackColor = Color.FromArgb(33, 33, 44); // 원래 배경색으로 변경
                    roi_name.ForeColor = Color.FromArgb(240, 240, 244); // 원래 글자색으로 변경
                    name = roi_name.Text; // 이름 값 업데이트

                    // 텍스트박스의 커서 숨기기
                    if (Parent != null)
                    {
                        Parent.Focus();
                    }
                }
            }
        }
        public void relocateCheckBox(int x, int y)
        {
            checkbox_bg.Location = new Point(x, y);
        }

        public void resizeItemBox(int x, int y)
        {
            this.Size = new Size(x, y);
        }

        private void roi_color_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("ROI COLOR Change Box!!");
        }

        private void roi_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
