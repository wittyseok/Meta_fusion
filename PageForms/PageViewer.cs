using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Metafusion
{
    public partial class PageViewer : Form
    {
        #region custom_title_bar
        //---------------------
        //features for MenuBar
        //---------------------
        //constants for dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Constants for resizing border width
        private int resizeBorderWidth = 16; // Parameter to adjust resize border width

        // Variables for resizing logic
        private bool isResizing = false;
        private Point lastPoint;
        private FormWindowState previousWindowState;

        // AnimateWindow 플래그 상수
        private const int AW_HOR_POSITIVE = 0x00000001;
        private const int AW_HOR_NEGATIVE = 0x00000002;
        private const int AW_VER_POSITIVE = 0x00000004;
        private const int AW_VER_NEGATIVE = 0x00000008;
        private const int AW_CENTER = 0x00000010;
        private const int AW_HIDE = 0x00010000;
        private const int AW_ACTIVATE = 0x00020000;
        private const int AW_SLIDE = 0x00040000;
        private const int AW_BLEND = 0x00080000;

        // Constants for resizing border width
        private const int HT_LEFT = 10;
        private const int HT_RIGHT = 11;
        private const int HT_TOP = 12;
        private const int HT_TOPLEFT = 13;
        private const int HT_TOPRIGHT = 14;
        private const int HT_BOTTOM = 15;
        private const int HT_BOTTOMLEFT = 16;
        private const int HT_BOTTOMRIGHT = 17;

        //Win32 API
        // AnimateWindow 함수 선언
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

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
        private void InitializeDragability()
        {
            MenuBar.MouseDown += CustomPopupForm_MouseDown;
            MenuBar.MouseMove += CustomPopupForm_MouseMove;
            MenuBar.MouseUp += CustomPopupForm_MouseUp;
        }
        private void InitializeMenuBar()
        {
            // 이벤트 구독
            MenuBar.MinimizeClicked += MenuBar_MinimizeClicked;
            MenuBar.MaximizeClicked += MenuBar_MaximizeClicked;
            MenuBar.CloseClicked += MenuBar_CloseClicked;
            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
            // 폼의 초기 크기 설정
            this.Size = new Size(1600, 1000);
        }
        private void InitializeResizeHandler()
        {
            this.Resize += MainForm_Resize;
            previousWindowState = this.WindowState; // 초기 상태 저장
            this.Load += PageViewer_Load;
        }
        private void InitializeCustomTitleBar()
        {
            InitializeResizeHandler();
            InitializeDragability();
            InitializeMenuBar();
        }
        private void MenuBar_MinimizeClicked(object sender, EventArgs e)
        {
            // 폼 최소화 애니메이션
            AnimateWindow(this.Handle, 50, AW_BLEND | AW_HIDE);
            this.WindowState = FormWindowState.Minimized;

        }

        private void MenuBar_MaximizeClicked(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // 폼 복원
                this.WindowState = FormWindowState.Normal;
                //AnimateWindow(this.Handle, 500, AW_SLIDE | AW_VER_NEGATIVE);
                //todo: 애니메이션 삽입(위 코드 안됨)
            }
            else
            {
                // 폼 최대화
                //AnimateWindow(this.Handle, 200, AW_CENTER | AW_ACTIVATE | AW_SLIDE | AW_HOR_POSITIVE);
                //todo: 애니메이션 삽입(위 코드 안됨)
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MenuBar_CloseClicked(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 50, AW_BLEND | AW_HIDE);
            this.Close();
        }
        //resizability
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState != FormWindowState.Maximized)
            {
                lastPoint = new Point(e.X, e.Y);
                // Check if cursor is at the edge of the form for resizing cursor
                if (e.X <= resizeBorderWidth)
                    isResizing = true; // Left edge
                else if (e.X >= this.Width - resizeBorderWidth)
                    isResizing = true; // Right edge
                else if (e.Y <= resizeBorderWidth)
                    isResizing = true; // Top edge
                else if (e.Y >= this.Height - resizeBorderWidth)
                    isResizing = true; // Bottom edge
                else
                    isResizing = false;
            }
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                int deltaX = e.X - lastPoint.X;
                int deltaY = e.Y - lastPoint.Y;

                this.Width += deltaX;
                this.Height += deltaY;

                lastPoint = new Point(e.X, e.Y);
            }
            else
            {
                // Check if cursor is at the edge of the form for resizing cursor
                if (this.WindowState == FormWindowState.Maximized) { }
                else if (e.X <= resizeBorderWidth)
                    this.Cursor = Cursors.SizeWE; // Left edge
                else if (e.X >= this.Width - resizeBorderWidth)
                    this.Cursor = Cursors.SizeWE; // Right edge
                else if (e.Y <= resizeBorderWidth)
                    this.Cursor = Cursors.SizeNS; // Top edge
                else if (e.Y >= this.Height - resizeBorderWidth)
                    this.Cursor = Cursors.SizeNS; // Bottom edge
                else
                    this.Cursor = Cursors.Default;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
            this.Cursor = Cursors.Default;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case 0x84: // WM_NCHITTEST
                    Point cursor = this.PointToClient(Cursor.Position);
                    if (this.WindowState == FormWindowState.Maximized)
                    { }
                    else if (cursor.X <= resizeBorderWidth)
                        m.Result = (IntPtr)HT_LEFT;
                    else if (cursor.X >= this.Width - resizeBorderWidth)
                        m.Result = (IntPtr)HT_RIGHT;
                    else if (cursor.Y <= resizeBorderWidth)
                        m.Result = (IntPtr)HT_TOP;
                    else if (cursor.Y >= this.Height - resizeBorderWidth)
                        m.Result = (IntPtr)HT_BOTTOM;
                    else if (cursor.X <= resizeBorderWidth && cursor.Y <= resizeBorderWidth)
                        m.Result = (IntPtr)HT_TOPLEFT;
                    else if (cursor.X >= this.Width - resizeBorderWidth && cursor.Y <= resizeBorderWidth)
                        m.Result = (IntPtr)HT_TOPRIGHT;
                    else if (cursor.X <= resizeBorderWidth && cursor.Y >= this.Height - resizeBorderWidth)
                        m.Result = (IntPtr)HT_BOTTOMLEFT;
                    else if (cursor.X >= this.Width - resizeBorderWidth && cursor.Y >= this.Height - resizeBorderWidth)
                        m.Result = (IntPtr)HT_BOTTOMRIGHT;
                    break;
            }
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal && previousWindowState == FormWindowState.Minimized)
            {
                this.Refresh();
            }
            previousWindowState = this.WindowState; // 현재 상태를 이전 상태로 저장
        }
        //---------------------
        //features for MenuBar
        //---------------------
        #endregion

        private string tab_name = "viewer";
        private ROIListItem selectedItem;

        public PageViewer()
        {
            InitializeComponent();
            InitializeCustomTitleBar();
        }

        private async void InitializeAsync()
        {
            await Task.WhenAll(
            Task.Run(() => InitializeNavBar()),
            Task.Run(() => InitializeIOToolbar()),
            Task.Run(() => InitializeViewerToolbar()),
            Task.Run(() => InitializeDrawingToolbar()),
            Task.Run(() => InitializeLeftToolbar())
            // 다른 초기화 메서드들 추가
            );
        }

        private void InitializeNavBar()
        {
            //set navigationbar activated index: viewer(5)
            NavBar.ButtonActivatedIndex = 5;
            NavBar.TabClicked += NavBar_TabClicked; // 이벤트 구독
        }
        private void NavBar_TabClicked(object? sender, TabClickedEventArgs e)
        {
            string tab_name = e.TabName;
            //MessageBox.Show(tab_name); //debug
            FormSwitchManager.try_Switch(this, this.tab_name, tab_name);
        }

        private async void InitializeROIList()
        {
            List<ROIListItem> itemList = await ComposeROIList();

            if (ROIList.InvokeRequired)
            {
                ROIList.Invoke((MethodInvoker)delegate
                {
                    ROIList.SuspendLayout();
                    ROIList.SetItemList(itemList);
                    ROIList.ResumeLayout();
                });
            }
            else
            {
                ROIList.SuspendLayout();
                ROIList.SetItemList(itemList);
                ROIList.ResumeLayout();
            }
            ROIList.ItemClicked += Item_Clicked;
        }

        private async Task<List<ROIListItem>> ComposeROIList()
        {
            List<ROIListItem> itemList = new List<ROIListItem>();

            foreach (int i in Enumerable.Range(1, 30))
            {
                ROIListItem item = new ROIListItem(true, true, $"roi_item_{i}", Color.Red);
                itemList.Add(item);
            }

            return itemList;
        }

        private void Item_Clicked(object? sender, ROIListItem.ItemClickedEventArgs e)
        {
            ROIListItem item = e.ClickedItem;
            if (item != null)
            {
                //displayMetadata.set_Metadata(item);
                //MessageBox.Show(item.name);
                selectedItem = item;
            }
        }

        private void InitializeIOToolbar()
        {
            IOToolbar.TabClicked += IOToolbar_TabClicked; // 이벤트 구독
        }
        private void InitializeViewerToolbar()
        {
            ViewerToolbar.TabClicked += ViewerToolbar_TabClicked; // 이벤트 구독
        }
        private void InitializeDrawingToolbar()
        {
            DrawingToolbar.TabClicked += DrawingToolbar_TabClicked; // 이벤트 구독
        }
        private void InitializeLeftToolbar()
        {
            LeftToolbar.TabClicked += LeftToolbar_TabClicked; // 이벤트 구독
        }

        private void IOToolbar_TabClicked(object? sender, IOToolbar.TabClickedEventArgs e)
        {
            string tab_name = e.TabName;
            //todo: switch option
            switch (tab_name)
            {
                case "export":
                    using (ExportImportPopupForm popup = new ExportImportPopupForm())
                    {
                        popup.ShowDialog(); // 모달 팝업
                    }
                    break;
                case "save":
                    using (SavePopupForm popup = new SavePopupForm())
                    {
                        popup.ShowDialog(); // 모달 팝업
                    }
                    break;
                default:
                    MessageBox.Show(tab_name); //debug
                    break;
            }
        }
        private void ViewerToolbar_TabClicked(object? sender, ViewerToolbar.TabClickedEventArgs e)
        {
            string tab_name = e.TabName;
            DrawingToolbar.ButtonActivatedIndex = -1;
            //MessageBox.Show(tab_name);
            //todo: switch option
        }

        private void DrawingToolbar_TabClicked(object? sender, DrawingToolbar.TabClickedEventArgs e)
        {
            string tab_name = e.TabName;
            ViewerToolbar.ButtonActivatedIndex = -1;
            //MessageBox.Show(tab_name);
            //todo: switch option
        }
        private async void LeftToolbar_TabClicked(object? sender, LeftToolbar.TabClickedEventArgs e)
        {
            string tab_name = e.TabName;

            await Task.Run(() =>
            {
                // UI 스레드에서 실행되도록 Invoke 사용
                this.Invoke((MethodInvoker)delegate
                {
                    HandleLeftToolbarTabClick(tab_name);
                });
            });
        }

        private void HandleLeftToolbarTabClick(string tab_name)
        {

            //todo: switch option
            switch (tab_name)
            {
                case "toggle":
                    ROIList.ToggleCheckedItem();
                    break;
                case "sub":
                    ROIList.RemoveCheckedItem();
                    break;
                default:
                    MessageBox.Show(tab_name); //debug
                    break;
            }
        }

        private void NavBar_Load(object sender, EventArgs e)
        {

        }

        private void DrawingToolbar_Load(object sender, EventArgs e)
        {

        }

        private void PageViewer_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            InitializeDropDown();
            InitializeROIList();
            InitializeAsync(); // 비동기 초기화 메서드 호출
            this.ResumeLayout();
        }

        private void panel_show_image_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PageViewer_Load_1(object sender, EventArgs e)
        {

        }

        private void PageViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // 애플리케이션 종료
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {

        }

        private void frame_roi_color_selector_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ROIList_Load(object sender, EventArgs e)
        {

        }

        public class CustomComboBoxItem
        {
            public Color Color { get; set; }
            public string Text { get; set; }

            public CustomComboBoxItem(Color color, string text)
            {
                Color = color;
                Text = text;
            }

            public override string ToString()
            {
                return Text; // ComboBox에 표시되는 텍스트
            }
        }

        private void InitializeDropDown()
        {
            dropdown_roiColor.DrawItem += ComboBox_DrawItem;
            dropdown_roiColor.MeasureItem += ComboBox_MeasureItem;
            dropdown_roiColor.DrawMode = DrawMode.OwnerDrawVariable; // 항목 높이를 가변적으로 설정
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Red, "Red Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Green, "Green Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Blue, "Blue Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Red, "Red Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Green, "Green Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Blue, "Blue Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Red, "Red Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Green, "Green Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Blue, "Blue Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Red, "Red Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Green, "Green Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Blue, "Blue Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Red, "Red Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Green, "Green Item"));
            dropdown_roiColor.Items.Add(new CustomComboBoxItem(Color.Blue, "Blue Item"));
        }
        private void ComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 37; // 항목 높이를 37픽셀로 설정
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            CustomComboBoxItem item = (CustomComboBoxItem)dropdown_roiColor.Items[e.Index];

            // 배경 그리기
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(98, 98, 132)), e.Bounds);

            // 경계 그리기 (얇게)
            using (Pen pen = new Pen(Color.FromArgb(123, 123, 157), 1))
            {
                e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right - 1, e.Bounds.Bottom - 1);
            }

            // 색상 패널 그리기 (20x20 크기)
            using (SolidBrush brush = new SolidBrush(item.Color))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(e.Bounds.Left + 10, e.Bounds.Top + (e.Bounds.Height - 20) / 2, 20, 20));
            }

            // 텍스트 그리기
            e.Graphics.DrawString(item.Text, e.Font, Brushes.White, e.Bounds.Left + 34, e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2);

            e.DrawFocusRectangle();
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
