namespace Metafusion
{
    partial class PageViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                // 이벤트 핸들러 제거
                NavBar.TabClicked -= NavBar_TabClicked;
                IOToolbar.TabClicked -= IOToolbar_TabClicked;
                ViewerToolbar.TabClicked -= ViewerToolbar_TabClicked;
                DrawingToolbar.TabClicked -= DrawingToolbar_TabClicked;
                LeftToolbar.TabClicked -= LeftToolbar_TabClicked;
                ROIList.ItemClicked -= Item_Clicked;
                dropdown_roiColor.DrawItem -= ComboBox_DrawItem;
                dropdown_roiColor.MeasureItem -= ComboBox_MeasureItem;
                this.Resize -= MainForm_Resize;
                this.Load -= PageViewer_Load;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NavBar = new NavBarUserControl();
            frame_drawing = new Panel();
            panel_show_image = new Panel();
            panel_tools = new RoundedPanel();
            IOToolbar = new IOToolbar();
            DrawingToolbar = new DrawingToolbar();
            ViewerToolbar = new ViewerToolbar();
            panel1 = new Panel();
            tool_divider = new Panel();
            frame_options = new RoundedPanel();
            dropdown_storage = new FlatCombo_Normal();
            frame_roi_color_selector = new Panel();
            dropdown_roiColor = new FlatCombo();
            frame_roi_list = new Panel();
            ROIList = new ROIListControl();
            LeftToolbar = new LeftToolbar();
            MenuBar = new MenuBar();
            frame_drawing.SuspendLayout();
            panel_tools.SuspendLayout();
            frame_options.SuspendLayout();
            frame_roi_color_selector.SuspendLayout();
            frame_roi_list.SuspendLayout();
            SuspendLayout();
            // 
            // NavBar
            // 
            NavBar.ActivatedColor = Color.FromArgb(33, 33, 44);
            NavBar.ButtonActivatedIndex = 0;
            NavBar.DeactivatedColor = Color.FromArgb(98, 98, 132);
            NavBar.DownsideActivatedColor = Color.FromArgb(31, 186, 255);
            NavBar.DownsideDeactivatedColor = Color.FromArgb(62, 62, 84);
            NavBar.Location = new Point(16, 37);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(683, 37);
            NavBar.TabIndex = 0;
            NavBar.Load += NavBar_Load;
            // 
            // frame_drawing
            // 
            frame_drawing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frame_drawing.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_drawing.Controls.Add(panel_show_image);
            frame_drawing.Controls.Add(panel_tools);
            frame_drawing.Location = new Point(343, 90);
            frame_drawing.Name = "frame_drawing";
            frame_drawing.Size = new Size(1561, 970);
            frame_drawing.TabIndex = 1;
            // 
            // panel_show_image
            // 
            panel_show_image.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_show_image.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_show_image.BackColor = Color.Black;
            panel_show_image.Location = new Point(0, 59);
            panel_show_image.Name = "panel_show_image";
            panel_show_image.Size = new Size(1561, 911);
            panel_show_image.TabIndex = 1;
            panel_show_image.Paint += panel_show_image_Paint;
            // 
            // panel_tools
            // 
            panel_tools.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_tools.BackColor = Color.FromArgb(54, 54, 73);
            panel_tools.borderColor = Color.Red;
            panel_tools.BorderWidth = 0;
            panel_tools.Controls.Add(IOToolbar);
            panel_tools.Controls.Add(DrawingToolbar);
            panel_tools.Controls.Add(ViewerToolbar);
            panel_tools.Controls.Add(panel1);
            panel_tools.Controls.Add(tool_divider);
            panel_tools.CornerRadius = 4;
            panel_tools.Location = new Point(0, 0);
            panel_tools.MinimumSize = new Size(666, 48);
            panel_tools.Name = "panel_tools";
            panel_tools.ScrollDisabled = false;
            panel_tools.Size = new Size(1561, 48);
            panel_tools.TabIndex = 0;
            // 
            // IOToolbar
            // 
            IOToolbar.ActivatedColor = Color.FromArgb(211, 211, 222);
            IOToolbar.DeactivatedColor = Color.FromArgb(76, 76, 103);
            IOToolbar.Location = new Point(8, 8);
            IOToolbar.Name = "IOToolbar";
            IOToolbar.Size = new Size(130, 32);
            IOToolbar.TabIndex = 5;
            // 
            // DrawingToolbar
            // 
            DrawingToolbar.ActivatedColor = Color.FromArgb(211, 211, 222);
            DrawingToolbar.BackColor = Color.FromArgb(54, 54, 73);
            DrawingToolbar.ButtonActivatedIndex = -1;
            DrawingToolbar.DeactivatedColor = Color.FromArgb(76, 76, 103);
            DrawingToolbar.Location = new Point(431, 8);
            DrawingToolbar.Name = "DrawingToolbar";
            DrawingToolbar.Size = new Size(235, 32);
            DrawingToolbar.TabIndex = 4;
            DrawingToolbar.Load += DrawingToolbar_Load;
            // 
            // ViewerToolbar
            // 
            ViewerToolbar.ActivatedColor = Color.FromArgb(211, 211, 222);
            ViewerToolbar.BackColor = Color.FromArgb(54, 54, 73);
            ViewerToolbar.ButtonActivatedIndex = -1;
            ViewerToolbar.DeactivatedColor = Color.FromArgb(76, 76, 103);
            ViewerToolbar.Location = new Point(171, 8);
            ViewerToolbar.Name = "ViewerToolbar";
            ViewerToolbar.Size = new Size(227, 32);
            ViewerToolbar.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 98, 132);
            panel1.Location = new Point(414, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 32);
            panel1.TabIndex = 2;
            // 
            // tool_divider
            // 
            tool_divider.BackColor = Color.FromArgb(98, 98, 132);
            tool_divider.Location = new Point(154, 8);
            tool_divider.Name = "tool_divider";
            tool_divider.Size = new Size(1, 32);
            tool_divider.TabIndex = 1;
            // 
            // frame_options
            // 
            frame_options.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_options.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_options.BackColor = Color.FromArgb(54, 54, 73);
            frame_options.borderColor = Color.Red;
            frame_options.BorderWidth = 0;
            frame_options.Controls.Add(dropdown_storage);
            frame_options.Controls.Add(frame_roi_color_selector);
            frame_options.Controls.Add(frame_roi_list);
            frame_options.Controls.Add(LeftToolbar);
            frame_options.CornerRadius = 4;
            frame_options.Location = new Point(15, 90);
            frame_options.Name = "frame_options";
            frame_options.ScrollDisabled = false;
            frame_options.Size = new Size(309, 970);
            frame_options.TabIndex = 2;
            // 
            // dropdown_storage
            // 
            dropdown_storage.BackColor = Color.FromArgb(76, 76, 103);
            dropdown_storage.BorderColor = Color.FromArgb(182, 182, 201);
            dropdown_storage.ButtonColor = Color.FromArgb(76, 76, 103);
            dropdown_storage.DrawMode = DrawMode.OwnerDrawVariable;
            dropdown_storage.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdown_storage.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dropdown_storage.ForeColor = Color.White;
            dropdown_storage.FormattingEnabled = true;
            dropdown_storage.ItemHeight = 20;
            dropdown_storage.Location = new Point(8, 48);
            dropdown_storage.Name = "dropdown_storage";
            dropdown_storage.Size = new Size(293, 26);
            dropdown_storage.TabIndex = 7;
            dropdown_storage.Text_default = "Select Storage";
            // 
            // frame_roi_color_selector
            // 
            frame_roi_color_selector.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            frame_roi_color_selector.BackColor = Color.FromArgb(54, 54, 73);
            frame_roi_color_selector.Controls.Add(dropdown_roiColor);
            frame_roi_color_selector.Location = new Point(0, 926);
            frame_roi_color_selector.Name = "frame_roi_color_selector";
            frame_roi_color_selector.Size = new Size(309, 44);
            frame_roi_color_selector.TabIndex = 6;
            frame_roi_color_selector.Paint += frame_roi_color_selector_Paint;
            // 
            // comboBox
            // 
            dropdown_roiColor.BackColor = Color.FromArgb(76, 76, 103);
            dropdown_roiColor.BorderColor = Color.FromArgb(182, 182, 201);
            dropdown_roiColor.ButtonColor = Color.FromArgb(76, 76, 103);
            dropdown_roiColor.DrawMode = DrawMode.OwnerDrawVariable;
            dropdown_roiColor.DropDownHeight = 262;
            dropdown_roiColor.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdown_roiColor.FlatStyle = FlatStyle.Flat;
            dropdown_roiColor.Font = new Font("Pretendard Variable Medium", 9F);
            dropdown_roiColor.ForeColor = Color.White;
            dropdown_roiColor.FormattingEnabled = true;
            dropdown_roiColor.IntegralHeight = false;
            dropdown_roiColor.ItemHeight = 22;
            dropdown_roiColor.Location = new Point(8, 8);
            dropdown_roiColor.Name = "comboBox";
            dropdown_roiColor.Size = new Size(293, 28);
            dropdown_roiColor.TabIndex = 0;
            // 
            // frame_roi_list
            // 
            frame_roi_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_roi_list.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_roi_list.BackColor = Color.Black;
            frame_roi_list.Controls.Add(ROIList);
            frame_roi_list.Location = new Point(8, 82);
            frame_roi_list.Name = "frame_roi_list";
            frame_roi_list.Size = new Size(293, 844);
            frame_roi_list.TabIndex = 5;
            // 
            // ROIList
            // 
            ROIList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ROIList.BackColor = Color.Transparent;
            ROIList.Dock = DockStyle.Fill;
            ROIList.Location = new Point(0, 0);
            ROIList.Name = "ROIList";
            ROIList.Size = new Size(293, 844);
            ROIList.TabIndex = 0;
            ROIList.Load += ROIList_Load;
            // 
            // LeftToolbar
            // 
            LeftToolbar.ActivatedColor = Color.FromArgb(211, 211, 222);
            LeftToolbar.BackColor = Color.FromArgb(54, 54, 73);
            LeftToolbar.DeactivatedColor = Color.FromArgb(76, 76, 103);
            LeftToolbar.Location = new Point(8, 8);
            LeftToolbar.Name = "LeftToolbar";
            LeftToolbar.Size = new Size(212, 32);
            LeftToolbar.TabIndex = 4;
            // 
            // MenuBar
            // 
            MenuBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MenuBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MenuBar.BackColor = Color.Transparent;
            MenuBar.Location = new Point(0, 0);
            MenuBar.Name = "MenuBar";
            MenuBar.Size = new Size(1920, 37);
            MenuBar.TabIndex = 3;
            MenuBar.Load += MenuBar_Load;
            // 
            // PageViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 44);
            ClientSize = new Size(1920, 1080);
            Controls.Add(MenuBar);
            Controls.Add(frame_options);
            Controls.Add(frame_drawing);
            Controls.Add(NavBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1280, 720);
            Name = "PageViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viewer";
            FormClosed += PageViewer_FormClosed;
            Load += PageViewer_Load_1;
            frame_drawing.ResumeLayout(false);
            panel_tools.ResumeLayout(false);
            frame_options.ResumeLayout(false);
            frame_roi_color_selector.ResumeLayout(false);
            frame_roi_list.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NavBarUserControl NavBar;
        private Panel frame_drawing;
        private RoundedPanel panel_tools;
        private Panel panel_show_image;
        private RoundedPanel frame_options;
        private Panel tool_divider;
        private Panel panel1;
        private DrawingToolbar DrawingToolbar;
        private ViewerToolbar ViewerToolbar;
        private LeftToolbar LeftToolbar;
        private IOToolbar IOToolbar;
        private Panel frame_roi_list;
        private ROIListControl ROIList;
        private MenuBar MenuBar;
        private Panel frame_roi_color_selector;
        private FlatCombo dropdown_roiColor;
        private FlatCombo_Normal dropdown_storage;
    }
}