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
    public partial class ExportImportPopupForm : Form
    {
        //features for dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void CustomPopupForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void CustomPopupForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void CustomPopupForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public ExportImportPopupForm()
        {
            this.Visible = false;
            this.SuspendLayout();
            InitializeComponent();
            InitializeAsync();
            this.Shown += ExportImportPopupForm_Shown; // 폼이 처음 표시될 때 이벤트 핸들러 추가
        }

        private void InitializeDragability()
        {
            this.MouseDown += CustomPopupForm_MouseDown;
            this.MouseMove += CustomPopupForm_MouseMove;
            this.MouseUp += CustomPopupForm_MouseUp;
        }
        private async void ExportImportPopupForm_Shown(object sender, EventArgs e)
        {
            InitializeListAsync(); // 초기화 비동기적으로 수행
            this.ResumeLayout();
            this.Visible = true; // 초기화 작업 완료 후 폼을 보이도록 설정
        }
        private void InitializeSamplingRate()
        {
            // textbox_sampling_rate에 키 입력 이벤트 핸들러 추가
            textbox_sampling_rate.KeyPress += Textbox_sampling_rate_KeyPress;
            textbox_sampling_rate.TextChanged += Textbox_sampling_rate_TextChanged;
        }
        private async void InitializeAsync()
        {
            Task.WhenAll(
            Task.Run(() => InitializeSamplingRate()),
            Task.Run(() => InitializeDragability())
            );
        }
        private async Task InitializeListAsync()
        {
            // 비동기로 초기화 작업 수행
            await Task.Run(() =>
            {
                InitializeROIList(); // ROI 리스트 초기화 작업 수행
                                     // 기타 초기화 작업 수행
            });
        }

        private async void InitializeROIList()
        {
            List<ROIListItem_Export> itemList = await ComposeROIList();

            if (roiListControl_Export.InvokeRequired)
            {
                roiListControl_Export.Invoke((MethodInvoker)delegate
                {
                    roiListControl_Export.SuspendLayout();
                    roiListControl_Export.SetItemList(itemList);
                    roiListControl_Export.ResumeLayout();
                });
            }
            else
            {
                roiListControl_Export.SuspendLayout();
                roiListControl_Export.SetItemList(itemList);
                roiListControl_Export.ResumeLayout();
            }
        }

        private async Task<List<ROIListItem_Export>> ComposeROIList()
        {
            List<ROIListItem_Export> itemList = new List<ROIListItem_Export>();

            foreach (int i in Enumerable.Range(1, 30))
            {
                ROIListItem_Export item = new ROIListItem_Export(true, $"roi_item_{i}",Color.Red);
                itemList.Add(item);
            }

            return itemList;
        }


        private void AddSamplingRate(int amount)
        {
            if (int.TryParse(textbox_sampling_rate.Text, out int currentRate))
            {
                currentRate += amount;
                if (currentRate < 1) currentRate = 1; // 자연수 조건 유지
                textbox_sampling_rate.Text = currentRate.ToString();
            }
            else
            {
                // 정수가 아닌 값이 입력되어 있는 경우 1로 초기화
                textbox_sampling_rate.Text = "1";
            }
        }

        private void icon_up_Click(object sender, EventArgs e)
        {
            AddSamplingRate(1);
        }

        private void icon_down_Click(object sender, EventArgs e)
        {
            AddSamplingRate(-1);
        }

        // 텍스트 박스에 숫자만 입력할 수 있도록 하는 이벤트 핸들러
        private void Textbox_sampling_rate_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // 숫자와 제어 문자만 허용
            e.Handled = !(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar));
        }

        // 텍스트 박스에 입력된 값이 자연수인지 확인
        private void Textbox_sampling_rate_TextChanged(object? sender, EventArgs e)
        {
            if (int.TryParse(textbox_sampling_rate.Text, out int currentRate))
            {
                if (currentRate < 1)
                {
                    textbox_sampling_rate.Text = "1";
                }
            }
            else
            {
                textbox_sampling_rate.Text = "1";
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            //todo: do something before close!
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportImportPopupForm_Load(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

    }
}
