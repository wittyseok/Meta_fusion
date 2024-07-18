namespace Metafusion
{
    partial class PageItemDetail
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
            frame_data = new Panel();
            frame_patientlist = new RoundedPanel();
            moduleRegion_patientList = new RoundedPanel();
            patientListControl = new PatientListControl();
            label1 = new Label();
            frame_control = new Panel();
            frame_metadata = new Panel();
            moduleRegion_metadata = new Panel();
            displayMetadata = new DisplayMetadataControl();
            label2 = new Label();
            moduleRegion_save_data = new Panel();
            saveData = new SaveDataControl();
            frame_info.SuspendLayout();
            frame_data.SuspendLayout();
            frame_patientlist.SuspendLayout();
            moduleRegion_patientList.SuspendLayout();
            frame_control.SuspendLayout();
            frame_metadata.SuspendLayout();
            moduleRegion_metadata.SuspendLayout();
            moduleRegion_save_data.SuspendLayout();
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
            MenuBar.Load += MenuBar_Load_1;
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
            frame_info.Controls.Add(frame_data);
            frame_info.Controls.Add(frame_control);
            frame_info.Location = new Point(16, 93);
            frame_info.Name = "frame_info";
            frame_info.Size = new Size(1888, 970);
            frame_info.TabIndex = 2;
            // 
            // frame_data
            // 
            frame_data.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frame_data.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_data.Controls.Add(frame_patientlist);
            frame_data.Controls.Add(label1);
            frame_data.Location = new Point(414, 0);
            frame_data.Name = "frame_data";
            frame_data.Size = new Size(1475, 970);
            frame_data.TabIndex = 4;
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
            frame_patientlist.Size = new Size(1475, 941);
            frame_patientlist.TabIndex = 5;
            frame_patientlist.Paint += moduleRegion_patientlist_Paint;
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
            moduleRegion_patientList.Size = new Size(1459, 925);
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
            patientListControl.Size = new Size(1559, 925);
            patientListControl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Patient List";
            // 
            // frame_control
            // 
            frame_control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_control.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_control.Controls.Add(frame_metadata);
            frame_control.Controls.Add(moduleRegion_save_data);
            frame_control.Location = new Point(0, 0);
            frame_control.Name = "frame_control";
            frame_control.Size = new Size(400, 970);
            frame_control.TabIndex = 3;
            // 
            // frame_metadata
            // 
            frame_metadata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_metadata.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_metadata.Controls.Add(moduleRegion_metadata);
            frame_metadata.Controls.Add(label2);
            frame_metadata.Location = new Point(0, 0);
            frame_metadata.Name = "frame_metadata";
            frame_metadata.Size = new Size(400, 803);
            frame_metadata.TabIndex = 5;
            frame_metadata.Paint += frame_metadata_Paint;
            // 
            // moduleRegion_metadata
            // 
            moduleRegion_metadata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            moduleRegion_metadata.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            moduleRegion_metadata.Controls.Add(displayMetadata);
            moduleRegion_metadata.Location = new Point(0, 30);
            moduleRegion_metadata.Name = "moduleRegion_metadata";
            moduleRegion_metadata.Size = new Size(400, 774);
            moduleRegion_metadata.TabIndex = 7;
            // 
            // displayMetadata
            // 
            displayMetadata.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            displayMetadata.BackColor = Color.FromArgb(33, 33, 44);
            displayMetadata.Dock = DockStyle.Fill;
            displayMetadata.Location = new Point(0, 0);
            displayMetadata.Name = "displayMetadata";
            displayMetadata.Size = new Size(400, 774);
            displayMetadata.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Menu Name";
            // 
            // moduleRegion_save_data
            // 
            moduleRegion_save_data.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            moduleRegion_save_data.Controls.Add(saveData);
            moduleRegion_save_data.Location = new Point(0, 819);
            moduleRegion_save_data.Name = "moduleRegion_save_data";
            moduleRegion_save_data.Size = new Size(400, 151);
            moduleRegion_save_data.TabIndex = 4;
            // 
            // saveData
            // 
            saveData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveData.BackColor = Color.FromArgb(33, 33, 44);
            saveData.Dock = DockStyle.Fill;
            saveData.Location = new Point(0, 0);
            saveData.Name = "saveData";
            saveData.Size = new Size(400, 151);
            saveData.TabIndex = 8;
            // 
            // PageItemDetail
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
            Name = "PageItemDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PageItemDetail";
            FormClosed += PageItemDetail_FormClosed;
            Load += PageItemDetail_Load_1;
            frame_info.ResumeLayout(false);
            frame_data.ResumeLayout(false);
            frame_data.PerformLayout();
            frame_patientlist.ResumeLayout(false);
            moduleRegion_patientList.ResumeLayout(false);
            frame_control.ResumeLayout(false);
            frame_metadata.ResumeLayout(false);
            frame_metadata.PerformLayout();
            moduleRegion_metadata.ResumeLayout(false);
            moduleRegion_save_data.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuBar MenuBar;
        private NavBarUserControl NavBar;
        private Panel frame_info;
        private Panel frame_control;
        private Panel frame_data;
        private Panel moduleRegion_save_data;
        private Panel frame_metadata;
        private Label label1;
        private RoundedPanel frame_patientlist;
        private Label label2;
        private Panel moduleRegion_metadata;
        private SaveDataControl saveData;
        private DisplayMetadataControl displayMetadata;
        private RoundedPanel moduleRegion_patientList;
        private PatientListControl patientListControl;
    }
}