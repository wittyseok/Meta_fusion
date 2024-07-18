namespace Metafusion
{
    partial class PageHome
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            MenuBar = new MenuBar();
            NavBar = new NavBarUserControl();
            frame_info = new Panel();
            panel_function = new Panel();
            ModuleRegion_SelectFunction = new Panel();
            selectFunctionControl = new Modules.Page_dedicated.Home.SelectFunctionControl();
            label1 = new Label();
            panel_step4 = new RoundedPanel();
            label5 = new Label();
            frame_data = new Panel();
            label_step3 = new Label();
            panel_step3 = new RoundedPanel();
            label4 = new Label();
            frame_patientlist = new RoundedPanel();
            moduleRegion_patientList = new RoundedPanel();
            patientListControl = new PatientListControl();
            frame_control = new Panel();
            ModuleRegion_SelectLists = new Panel();
            label3 = new Label();
            panel_step2 = new RoundedPanel();
            label_step2 = new Label();
            frame_search = new Panel();
            ModuleRegion_SetFilters = new Panel();
            setFilterControl = new Modules.Page_dedicated.Home.SetFilterControl();
            label2 = new Label();
            panel_step1 = new RoundedPanel();
            label_step1 = new Label();
            frame_info.SuspendLayout();
            panel_function.SuspendLayout();
            ModuleRegion_SelectFunction.SuspendLayout();
            panel_step4.SuspendLayout();
            frame_data.SuspendLayout();
            panel_step3.SuspendLayout();
            frame_patientlist.SuspendLayout();
            moduleRegion_patientList.SuspendLayout();
            frame_control.SuspendLayout();
            panel_step2.SuspendLayout();
            frame_search.SuspendLayout();
            ModuleRegion_SetFilters.SuspendLayout();
            panel_step1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuBar
            // 
            MenuBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MenuBar.BackColor = Color.Transparent;
            MenuBar.Dock = DockStyle.Top;
            MenuBar.Location = new Point(0, 0);
            MenuBar.Name = "MenuBar";
            MenuBar.Size = new Size(1920, 37);
            MenuBar.TabIndex = 0;
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
            NavBar.TabIndex = 1;
            // 
            // frame_info
            // 
            frame_info.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frame_info.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_info.Controls.Add(panel_function);
            frame_info.Controls.Add(frame_data);
            frame_info.Controls.Add(frame_control);
            frame_info.Location = new Point(16, 93);
            frame_info.Name = "frame_info";
            frame_info.Size = new Size(1888, 970);
            frame_info.TabIndex = 2;
            frame_info.Paint += frame_info_Paint;
            // 
            // panel_function
            // 
            panel_function.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_function.Controls.Add(ModuleRegion_SelectFunction);
            panel_function.Controls.Add(label1);
            panel_function.Controls.Add(panel_step4);
            panel_function.Location = new Point(1634, 0);
            panel_function.Name = "panel_function";
            panel_function.Size = new Size(254, 970);
            panel_function.TabIndex = 19;
            // 
            // ModuleRegion_SelectFunction
            // 
            ModuleRegion_SelectFunction.Controls.Add(selectFunctionControl);
            ModuleRegion_SelectFunction.Location = new Point(14, 30);
            ModuleRegion_SelectFunction.Name = "ModuleRegion_SelectFunction";
            ModuleRegion_SelectFunction.Size = new Size(240, 250);
            ModuleRegion_SelectFunction.TabIndex = 18;
            // 
            // selectFunctionControl
            // 
            selectFunctionControl.BackColor = Color.FromArgb(33, 33, 44);
            selectFunctionControl.Location = new Point(0, 0);
            selectFunctionControl.Name = "selectFunctionControl";
            selectFunctionControl.Size = new Size(240, 250);
            selectFunctionControl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 3);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 17;
            label1.Text = "Select Function";
            // 
            // panel_step4
            // 
            panel_step4.BackColor = Color.FromArgb(12, 1, 89);
            panel_step4.borderColor = Color.Red;
            panel_step4.BorderWidth = 0;
            panel_step4.Controls.Add(label5);
            panel_step4.CornerRadius = 4;
            panel_step4.Location = new Point(14, 0);
            panel_step4.Name = "panel_step4";
            panel_step4.ScrollDisabled = false;
            panel_step4.Size = new Size(46, 22);
            panel_step4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.FromArgb(202, 194, 254);
            label5.Location = new Point(2, 4);
            label5.Name = "label5";
            label5.Size = new Size(45, 14);
            label5.TabIndex = 5;
            label5.Text = "STEP 4";
            // 
            // frame_data
            // 
            frame_data.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_data.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_data.Controls.Add(label_step3);
            frame_data.Controls.Add(panel_step3);
            frame_data.Controls.Add(frame_patientlist);
            frame_data.Location = new Point(414, 0);
            frame_data.Name = "frame_data";
            frame_data.Size = new Size(1220, 970);
            frame_data.TabIndex = 4;
            // 
            // label_step3
            // 
            label_step3.AutoSize = true;
            label_step3.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label_step3.ForeColor = Color.White;
            label_step3.Location = new Point(54, 3);
            label_step3.Name = "label_step3";
            label_step3.Size = new Size(73, 15);
            label_step3.TabIndex = 9;
            label_step3.Text = "Select Data";
            // 
            // panel_step3
            // 
            panel_step3.BackColor = Color.FromArgb(12, 1, 89);
            panel_step3.borderColor = Color.Red;
            panel_step3.BorderWidth = 0;
            panel_step3.Controls.Add(label4);
            panel_step3.CornerRadius = 4;
            panel_step3.Location = new Point(0, 0);
            panel_step3.Name = "panel_step3";
            panel_step3.ScrollDisabled = false;
            panel_step3.Size = new Size(46, 22);
            panel_step3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.FromArgb(202, 194, 254);
            label4.Location = new Point(2, 4);
            label4.Name = "label4";
            label4.Size = new Size(45, 14);
            label4.TabIndex = 5;
            label4.Text = "STEP 3";
            // 
            // frame_patientlist
            // 
            frame_patientlist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_patientlist.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_patientlist.BackColor = Color.FromArgb(54, 54, 73);
            frame_patientlist.borderColor = Color.Red;
            frame_patientlist.BorderWidth = 0;
            frame_patientlist.Controls.Add(moduleRegion_patientList);
            frame_patientlist.CornerRadius = 4;
            frame_patientlist.Location = new Point(0, 30);
            frame_patientlist.Name = "frame_patientlist";
            frame_patientlist.ScrollDisabled = false;
            frame_patientlist.Size = new Size(1474, 940);
            frame_patientlist.TabIndex = 5;
            // 
            // moduleRegion_patientList
            // 
            moduleRegion_patientList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            moduleRegion_patientList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            moduleRegion_patientList.BackColor = Color.FromArgb(54, 54, 73);
            moduleRegion_patientList.borderColor = Color.Red;
            moduleRegion_patientList.BorderWidth = 0;
            moduleRegion_patientList.Controls.Add(patientListControl);
            moduleRegion_patientList.CornerRadius = 4;
            moduleRegion_patientList.Location = new Point(8, 8);
            moduleRegion_patientList.Name = "moduleRegion_patientList";
            moduleRegion_patientList.ScrollDisabled = false;
            moduleRegion_patientList.Size = new Size(1459, 924);
            moduleRegion_patientList.TabIndex = 7;
            // 
            // patientListControl
            // 
            patientListControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            patientListControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            patientListControl.BackColor = Color.FromArgb(54, 54, 73);
            patientListControl.Location = new Point(0, 0);
            patientListControl.Margin = new Padding(0);
            patientListControl.Name = "patientListControl";
            patientListControl.Size = new Size(1559, 924);
            patientListControl.TabIndex = 1;
            // 
            // frame_control
            // 
            frame_control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_control.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_control.Controls.Add(ModuleRegion_SelectLists);
            frame_control.Controls.Add(label3);
            frame_control.Controls.Add(panel_step2);
            frame_control.Controls.Add(frame_search);
            frame_control.Location = new Point(0, 0);
            frame_control.Name = "frame_control";
            frame_control.Size = new Size(400, 970);
            frame_control.TabIndex = 3;
            // 
            // ModuleRegion_SelectLists
            // 
            ModuleRegion_SelectLists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ModuleRegion_SelectLists.Location = new Point(0, 313);
            ModuleRegion_SelectLists.Name = "ModuleRegion_SelectLists";
            ModuleRegion_SelectLists.Size = new Size(400, 657);
            ModuleRegion_SelectLists.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 286);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Select Lists";
            // 
            // panel_step2
            // 
            panel_step2.BackColor = Color.FromArgb(12, 1, 89);
            panel_step2.borderColor = Color.Red;
            panel_step2.BorderWidth = 0;
            panel_step2.Controls.Add(label_step2);
            panel_step2.CornerRadius = 4;
            panel_step2.Location = new Point(0, 283);
            panel_step2.Name = "panel_step2";
            panel_step2.ScrollDisabled = false;
            panel_step2.Size = new Size(46, 22);
            panel_step2.TabIndex = 6;
            // 
            // label_step2
            // 
            label_step2.AutoSize = true;
            label_step2.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label_step2.ForeColor = Color.FromArgb(202, 194, 254);
            label_step2.Location = new Point(2, 4);
            label_step2.Name = "label_step2";
            label_step2.Size = new Size(45, 14);
            label_step2.TabIndex = 5;
            label_step2.Text = "STEP 2";
            // 
            // frame_search
            // 
            frame_search.Controls.Add(ModuleRegion_SetFilters);
            frame_search.Controls.Add(label2);
            frame_search.Controls.Add(panel_step1);
            frame_search.Location = new Point(0, 0);
            frame_search.Name = "frame_search";
            frame_search.Size = new Size(400, 267);
            frame_search.TabIndex = 5;
            // 
            // ModuleRegion_SetFilters
            // 
            ModuleRegion_SetFilters.Controls.Add(setFilterControl);
            ModuleRegion_SetFilters.Location = new Point(0, 30);
            ModuleRegion_SetFilters.Name = "ModuleRegion_SetFilters";
            ModuleRegion_SetFilters.Size = new Size(400, 237);
            ModuleRegion_SetFilters.TabIndex = 4;
            // 
            // setFilterControl
            // 
            setFilterControl.BackColor = Color.FromArgb(33, 33, 44);
            setFilterControl.Location = new Point(0, 0);
            setFilterControl.Name = "setFilterControl";
            setFilterControl.Size = new Size(400, 237);
            setFilterControl.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 3);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Set Filters";
            label2.Click += label2_Click;
            // 
            // panel_step1
            // 
            panel_step1.BackColor = Color.FromArgb(12, 1, 89);
            panel_step1.borderColor = Color.Red;
            panel_step1.BorderWidth = 0;
            panel_step1.Controls.Add(label_step1);
            panel_step1.CornerRadius = 4;
            panel_step1.Location = new Point(0, 0);
            panel_step1.Name = "panel_step1";
            panel_step1.ScrollDisabled = false;
            panel_step1.Size = new Size(46, 22);
            panel_step1.TabIndex = 2;
            // 
            // label_step1
            // 
            label_step1.AutoSize = true;
            label_step1.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label_step1.ForeColor = Color.FromArgb(202, 194, 254);
            label_step1.Location = new Point(2, 4);
            label_step1.Name = "label_step1";
            label_step1.Size = new Size(43, 14);
            label_step1.TabIndex = 5;
            label_step1.Text = "STEP 1";
            // 
            // PageHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 44);
            ClientSize = new Size(1920, 1080);
            Controls.Add(frame_info);
            Controls.Add(NavBar);
            Controls.Add(MenuBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1280, 720);
            Name = "PageHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PageItemDetail";
            FormClosed += PageItemDetail_FormClosed;
            Load += PageHome_Load;
            frame_info.ResumeLayout(false);
            panel_function.ResumeLayout(false);
            panel_function.PerformLayout();
            ModuleRegion_SelectFunction.ResumeLayout(false);
            panel_step4.ResumeLayout(false);
            panel_step4.PerformLayout();
            frame_data.ResumeLayout(false);
            frame_data.PerformLayout();
            panel_step3.ResumeLayout(false);
            panel_step3.PerformLayout();
            frame_patientlist.ResumeLayout(false);
            moduleRegion_patientList.ResumeLayout(false);
            frame_control.ResumeLayout(false);
            frame_control.PerformLayout();
            panel_step2.ResumeLayout(false);
            panel_step2.PerformLayout();
            frame_search.ResumeLayout(false);
            frame_search.PerformLayout();
            ModuleRegion_SetFilters.ResumeLayout(false);
            panel_step1.ResumeLayout(false);
            panel_step1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuBar MenuBar;
        private NavBarUserControl NavBar;
        private Panel frame_info;
        private Panel frame_control;
        private Panel frame_data;
        private RoundedPanel frame_patientlist;
        private RoundedPanel moduleRegion_patientList;
        private PatientListControl patientListControl;
        private Panel frame_search;
        private Label label2;
        private RoundedPanel panel_step1;
        private Label label_step1;
        private RoundedPanel panel_step2;
        private Label label_step2;
        private Label label3;
        private Panel ModuleRegion_SetFilters;
        private Panel ModuleRegion_SelectLists;
        private Label label_step3;
        private RoundedPanel panel_step3;
        private Label label4;
        private Panel panel_function;
        private Panel ModuleRegion_SelectFunction;
        private Label label1;
        private RoundedPanel panel_step4;
        private Label label5;
        private Modules.Page_dedicated.Home.SetFilterControl setFilterControl;
        private Modules.Page_dedicated.Home.SelectFunctionControl selectFunctionControl;
    }
}