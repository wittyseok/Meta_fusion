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

namespace Metafusion
{
    public partial class PageItemDetail : Form
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
            this.Load += PageItemDetail_Load;
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

            patientListControl.Size = new Size(1459+(1920-this.Size.Width), moduleRegion_patientList.Size.Height); // 환자 리스트 가로 스크롤
        }
        //---------------------
        //features for MenuBar
        //---------------------
        #endregion
        private string tab_name = "item1";
        private int tab_index = 1;
        private PatientListItem selectedItem;
        public PageItemDetail()
        {
            InitializeComponent();
            InitializeCustomTitleBar();
            InitializePatientListScroll();
        }
        private async void InitializeAsync()
        {
            await Task.WhenAll(
            Task.Run(() => InitializeNavBar()),
            Task.Run(() => InitializePatientList())
            // 다른 초기화 메서드들 추가
            );
        }
        private bool navbar_initialized = false;
        private void InitializeNavBar()
        {
            if (navbar_initialized)
                return;
            navbar_initialized = true;
            //set navigationbar activated index: item1(1), item3(2), item5(3), itemtooth(4)
            NavBar.ButtonActivatedIndex = tab_index;
            NavBar.TabClicked += NavBar_TabClicked; // 이벤트 구독
        }

        private void InitializePatientListScroll()
        {
            //환자 리스트 가로 스크롤
            moduleRegion_patientList.AutoScroll = false;
            moduleRegion_patientList.VerticalScroll.Maximum = 0;
            moduleRegion_patientList.AutoScroll = true;
            moduleRegion_patientList.ScrollDisabled = true;
        }

        private async void InitializePatientList()
        {
            List<PatientListItem> itemList = await ComposePatientList();

            if (patientListControl.InvokeRequired)
            {
                patientListControl.Invoke((MethodInvoker)delegate
                {
                    patientListControl.SuspendLayout();
                    patientListControl.SetItemList(itemList);
                    patientListControl.ResumeLayout();
                });
            }
            else
            {
                patientListControl.SuspendLayout();
                patientListControl.SetItemList(itemList);
                patientListControl.ResumeLayout();
            }

            patientListControl.ItemClicked += Item_Clicked;
        }

        private void Item_Clicked(object? sender, PatientListItem.ItemClickedEventArgs e)
        {
            PatientListItem item = e.ClickedItem;
            if (item != null)
            {
                displayMetadata.set_Metadata(item);
                selectedItem = item;
            }
        }

        private async Task<List<PatientListItem>> ComposePatientList()
        {
            List<PatientListItem> itemList = new List<PatientListItem>();

            for (int j = 0; j < 10; j++)
            {
                foreach (int i in Enumerable.Range(1, 10))
                {
                    //stage, id, name, storage, modality, series_description, series_date, series_time, study_description, study_date
                    PatientListItem item = new PatientListItem("stored", $"Patient_ID_{i}", $"Patient_Name_{i}", "local(C:\\)", "CT", $"series_description_{i}", $"2024.07.11.", "11:04:11", "study_description", "2024.07.06.");
                    itemList.Add(item);
                }

                foreach (int i in Enumerable.Range(1, 10))
                {
                    PatientListItem item = new PatientListItem("inference", $"Patient_ID_{i}", $"Patient_Name_{i}", "local(C:\\)", "CT", $"series_description_{i}", "2024.07.14.", "11:04:11", "study_description", "2024.07.06.");
                    itemList.Add(item);
                }

                foreach (int i in Enumerable.Range(1, 10))
                {
                    PatientListItem item = new PatientListItem("ready", $"Patient_ID_{i}", $"Patient_Name_{i}", "local(C:\\)", "CT", $"series_description_{i}", "2024.07.15.", "11:04:11", "study_description", "2024.07.06.");
                    itemList.Add(item);
                }

                foreach (int i in Enumerable.Range(1, 10))
                {
                    PatientListItem item = new PatientListItem("none", $"Patient_ID_{i}", $"Patient_Name_{i}", "local(C:\\)", "CT", $"series_description_{i}", "2024.07.01.", "11:04:11", "study_description", "2024.07.06.");
                    itemList.Add(item);
                }
            }

            return itemList;
        }

        private void NavBar_TabClicked(object? sender, TabClickedEventArgs e)
        {
            string tab_name = e.TabName;
            //MessageBox.Show(tab_name); //debug
            FormSwitchManager.try_Switch(this, this.tab_name, tab_name);
        }

        public void SetPageIndex(int index)
        {
            this.tab_index = index;
            switch (index)
            {
                case 1: //item1
                    this.tab_name = "item1";
                    break;
                case 2: //item3
                    this.tab_name = "item3";
                    break;
                case 3: //item5
                    this.tab_name = "item5";
                    break;
                case 4: //itemtooth
                    this.tab_name = "itemtooth";
                    break;
                default:
                    break;
            }
        }

        private void PageItemDetail_Load(object sender, EventArgs e)
        {
            InitializeAsync();
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {

        }

        private void PageItemDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // 애플리케이션 종료
        }

        private void MenuBar_Load_1(object sender, EventArgs e)
        {

        }

        private void frame_metadata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moduleRegion_patientlist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientListControl_Load(object sender, EventArgs e)
        {

        }

        private void PageItemDetail_Load_1(object sender, EventArgs e)
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
