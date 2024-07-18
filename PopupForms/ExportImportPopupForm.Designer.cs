namespace Metafusion
{
    partial class ExportImportPopupForm
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
                this.MouseDown -= CustomPopupForm_MouseDown;
                this.MouseMove -= CustomPopupForm_MouseMove;
                this.MouseUp -= CustomPopupForm_MouseUp;
                this.Shown -= ExportImportPopupForm_Shown;
                textbox_sampling_rate.KeyPress -= Textbox_sampling_rate_KeyPress;
                textbox_sampling_rate.TextChanged -= Textbox_sampling_rate_TextChanged;
                icon_down.Click -= icon_down_Click;
                icon_up.Click -= icon_up_Click;
                button_cancel.Click -= button_cancel_Click;
                button_ok.Click -= button_ok_Click;

                // Dispose child controls
                foreach (Control control in this.Controls)
                {
                    control.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportImportPopupForm));
            panel_content = new Panel();
            panel_import = new Panel();
            label1 = new Label();
            panel_export = new Panel();
            panel_export_roi = new RoundedPanel();
            frame_roi_list = new Panel();
            roiListControl_Export = new ROIListControl_Export();
            panel_export_options = new Panel();
            panel_localpath = new Panel();
            Selector_path_Export = new Button_Selector();
            label6 = new Label();
            panel_export_ct = new Panel();
            checkbox_export_ct = new SmallCheckBox();
            label5 = new Label();
            panel_sampling_rate = new Panel();
            icon_down = new PictureBox();
            icon_up = new PictureBox();
            input_bg_sampling_rate = new RoundedPanel();
            textbox_sampling_rate = new TextBox();
            label4 = new Label();
            panel_compress = new Panel();
            checkbox_compress = new SmallCheckBox();
            label3 = new Label();
            panel_export_img_type = new Panel();
            label8 = new Label();
            label7 = new Label();
            checkbox_export_stl = new SmallCheckBox();
            checkbox_export_nii = new SmallCheckBox();
            label2 = new Label();
            label_export = new Label();
            label_title = new Label();
            button_ok = new RoundedButton();
            button_cancel = new RoundedButton();
            Selector_path_import = new Button_Selector();
            panel_content.SuspendLayout();
            panel_import.SuspendLayout();
            panel_export.SuspendLayout();
            panel_export_roi.SuspendLayout();
            frame_roi_list.SuspendLayout();
            panel_export_options.SuspendLayout();
            panel_localpath.SuspendLayout();
            panel_export_ct.SuspendLayout();
            panel_sampling_rate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_up).BeginInit();
            input_bg_sampling_rate.SuspendLayout();
            panel_compress.SuspendLayout();
            panel_export_img_type.SuspendLayout();
            SuspendLayout();
            // 
            // panel_content
            // 
            panel_content.Controls.Add(panel_import);
            panel_content.Controls.Add(panel_export);
            panel_content.Location = new Point(12, 50);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(576, 690);
            panel_content.TabIndex = 3;
            // 
            // panel_import
            // 
            panel_import.BackColor = Color.FromArgb(33, 33, 44);
            panel_import.Controls.Add(Selector_path_import);
            panel_import.Controls.Add(label1);
            panel_import.Location = new Point(0, 590);
            panel_import.Name = "panel_import";
            panel_import.Size = new Size(576, 100);
            panel_import.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard Variable", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 2;
            label1.Text = "Import";
            // 
            // panel_export
            // 
            panel_export.BackColor = Color.FromArgb(33, 33, 44);
            panel_export.Controls.Add(panel_export_roi);
            panel_export.Controls.Add(panel_export_options);
            panel_export.Controls.Add(label_export);
            panel_export.Location = new Point(0, 0);
            panel_export.Name = "panel_export";
            panel_export.Size = new Size(576, 574);
            panel_export.TabIndex = 0;
            // 
            // panel_export_roi
            // 
            panel_export_roi.BackColor = Color.FromArgb(54, 54, 73);
            panel_export_roi.borderColor = Color.Red;
            panel_export_roi.BorderWidth = 0;
            panel_export_roi.Controls.Add(frame_roi_list);
            panel_export_roi.CornerRadius = 4;
            panel_export_roi.Location = new Point(16, 58);
            panel_export_roi.Name = "panel_export_roi";
            panel_export_roi.ScrollDisabled = false;
            panel_export_roi.Size = new Size(264, 500);
            panel_export_roi.TabIndex = 4;
            // 
            // frame_roi_list
            // 
            frame_roi_list.BackColor = Color.Black;
            frame_roi_list.Controls.Add(roiListControl_Export);
            frame_roi_list.Location = new Point(8, 8);
            frame_roi_list.Name = "frame_roi_list";
            frame_roi_list.Size = new Size(254, 484);
            frame_roi_list.TabIndex = 5;
            // 
            // roiListControl_Export
            // 
            roiListControl_Export.BackColor = Color.Transparent;
            roiListControl_Export.Dock = DockStyle.Fill;
            roiListControl_Export.Location = new Point(0, 0);
            roiListControl_Export.Name = "roiListControl_Export";
            roiListControl_Export.Size = new Size(254, 484);
            roiListControl_Export.TabIndex = 0;
            // 
            // panel_export_options
            // 
            panel_export_options.BackColor = Color.FromArgb(33, 33, 44);
            panel_export_options.Controls.Add(panel_localpath);
            panel_export_options.Controls.Add(panel_export_ct);
            panel_export_options.Controls.Add(panel_sampling_rate);
            panel_export_options.Controls.Add(panel_compress);
            panel_export_options.Controls.Add(panel_export_img_type);
            panel_export_options.Location = new Point(296, 58);
            panel_export_options.Name = "panel_export_options";
            panel_export_options.Size = new Size(264, 500);
            panel_export_options.TabIndex = 4;
            // 
            // panel_localpath
            // 
            panel_localpath.BackColor = Color.FromArgb(33, 33, 44);
            panel_localpath.Controls.Add(Selector_path_Export);
            panel_localpath.Controls.Add(label6);
            panel_localpath.Location = new Point(0, 296);
            panel_localpath.Name = "panel_localpath";
            panel_localpath.Size = new Size(264, 57);
            panel_localpath.TabIndex = 10;
            // 
            // Selector_path_Export
            // 
            Selector_path_Export.BackColor = Color.FromArgb(54, 54, 73);
            Selector_path_Export.Location = new Point(0, 31);
            Selector_path_Export.Name = "Selector_path_Export";
            Selector_path_Export.Size = new Size(264, 26);
            Selector_path_Export.TabIndex = 12;
            Selector_path_Export.Text = "button_Selector1";
            Selector_path_Export.Selector_icon = (Image)resources.GetObject("Selector_path_Export.Icon");
            Selector_path_Export.Text_default = "Select Path";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Local Path";
            // 
            // panel_export_ct
            // 
            panel_export_ct.BackColor = Color.FromArgb(33, 33, 44);
            panel_export_ct.Controls.Add(checkbox_export_ct);
            panel_export_ct.Controls.Add(label5);
            panel_export_ct.Location = new Point(0, 227);
            panel_export_ct.Name = "panel_export_ct";
            panel_export_ct.Size = new Size(264, 47);
            panel_export_ct.TabIndex = 9;
            // 
            // checkbox_export_ct
            // 
            checkbox_export_ct.BackColor = Color.Transparent;
            checkbox_export_ct.is_checked = true;
            checkbox_export_ct.Location = new Point(0, 31);
            checkbox_export_ct.Name = "checkbox_export_ct";
            checkbox_export_ct.Size = new Size(16, 16);
            checkbox_export_ct.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 5;
            label5.Text = "Export CT Images Too";
            // 
            // panel_sampling_rate
            // 
            panel_sampling_rate.BackColor = Color.FromArgb(33, 33, 44);
            panel_sampling_rate.Controls.Add(icon_down);
            panel_sampling_rate.Controls.Add(icon_up);
            panel_sampling_rate.Controls.Add(input_bg_sampling_rate);
            panel_sampling_rate.Controls.Add(label4);
            panel_sampling_rate.Location = new Point(0, 144);
            panel_sampling_rate.Name = "panel_sampling_rate";
            panel_sampling_rate.Size = new Size(264, 59);
            panel_sampling_rate.TabIndex = 8;
            // 
            // icon_down
            // 
            icon_down.BackgroundImage = Properties.Resources.icon_CaretDown;
            icon_down.BackgroundImageLayout = ImageLayout.Center;
            icon_down.Location = new Point(245, 44);
            icon_down.Name = "icon_down";
            icon_down.Size = new Size(16, 16);
            icon_down.TabIndex = 8;
            icon_down.TabStop = false;
            icon_down.Click += icon_down_Click;
            // 
            // icon_up
            // 
            icon_up.BackgroundImage = Properties.Resources.icon_CaretUp;
            icon_up.BackgroundImageLayout = ImageLayout.Center;
            icon_up.Location = new Point(245, 31);
            icon_up.Name = "icon_up";
            icon_up.Size = new Size(16, 16);
            icon_up.TabIndex = 7;
            icon_up.TabStop = false;
            icon_up.Click += icon_up_Click;
            // 
            // input_bg_sampling_rate
            // 
            input_bg_sampling_rate.BackColor = Color.FromArgb(240, 240, 244);
            input_bg_sampling_rate.borderColor = Color.Red;
            input_bg_sampling_rate.BorderWidth = 0;
            input_bg_sampling_rate.Controls.Add(textbox_sampling_rate);
            input_bg_sampling_rate.CornerRadius = 4;
            input_bg_sampling_rate.Location = new Point(0, 32);
            input_bg_sampling_rate.Name = "input_bg_sampling_rate";
            input_bg_sampling_rate.ScrollDisabled = false;
            input_bg_sampling_rate.Size = new Size(244, 26);
            input_bg_sampling_rate.TabIndex = 6;
            // 
            // textbox_sampling_rate
            // 
            textbox_sampling_rate.BackColor = Color.FromArgb(240, 240, 244);
            textbox_sampling_rate.BorderStyle = BorderStyle.None;
            textbox_sampling_rate.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textbox_sampling_rate.Location = new Point(6, 6);
            textbox_sampling_rate.Name = "textbox_sampling_rate";
            textbox_sampling_rate.Size = new Size(100, 15);
            textbox_sampling_rate.TabIndex = 0;
            textbox_sampling_rate.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 5;
            label4.Text = "Planar Sampling Rate";
            // 
            // panel_compress
            // 
            panel_compress.BackColor = Color.FromArgb(33, 33, 44);
            panel_compress.Controls.Add(checkbox_compress);
            panel_compress.Controls.Add(label3);
            panel_compress.Location = new Point(0, 73);
            panel_compress.Name = "panel_compress";
            panel_compress.Size = new Size(264, 47);
            panel_compress.TabIndex = 7;
            // 
            // checkbox_compress
            // 
            checkbox_compress.BackColor = Color.Transparent;
            checkbox_compress.is_checked = true;
            checkbox_compress.Location = new Point(0, 31);
            checkbox_compress.Name = "checkbox_compress";
            checkbox_compress.Size = new Size(16, 16);
            checkbox_compress.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Compress";
            // 
            // panel_export_img_type
            // 
            panel_export_img_type.BackColor = Color.FromArgb(33, 33, 44);
            panel_export_img_type.Controls.Add(label8);
            panel_export_img_type.Controls.Add(label7);
            panel_export_img_type.Controls.Add(checkbox_export_stl);
            panel_export_img_type.Controls.Add(checkbox_export_nii);
            panel_export_img_type.Controls.Add(label2);
            panel_export_img_type.Location = new Point(0, 0);
            panel_export_img_type.Name = "panel_export_img_type";
            panel_export_img_type.Size = new Size(264, 49);
            panel_export_img_type.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.ForeColor = Color.White;
            label8.Location = new Point(79, 32);
            label8.Name = "label8";
            label8.Size = new Size(20, 14);
            label8.TabIndex = 7;
            label8.Text = "stl";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 32);
            label7.Name = "label7";
            label7.Size = new Size(20, 14);
            label7.TabIndex = 6;
            label7.Text = "nii";
            // 
            // checkbox_export_stl
            // 
            checkbox_export_stl.BackColor = Color.Transparent;
            checkbox_export_stl.is_checked = true;
            checkbox_export_stl.Location = new Point(58, 31);
            checkbox_export_stl.Name = "checkbox_export_stl";
            checkbox_export_stl.Size = new Size(16, 16);
            checkbox_export_stl.TabIndex = 5;
            // 
            // checkbox_export_nii
            // 
            checkbox_export_nii.BackColor = Color.Transparent;
            checkbox_export_nii.is_checked = true;
            checkbox_export_nii.Location = new Point(0, 31);
            checkbox_export_nii.Name = "checkbox_export_nii";
            checkbox_export_nii.Size = new Size(16, 16);
            checkbox_export_nii.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Export Image Type";
            // 
            // label_export
            // 
            label_export.AutoSize = true;
            label_export.Font = new Font("Pretendard Variable", 15F, FontStyle.Bold);
            label_export.ForeColor = Color.White;
            label_export.Location = new Point(16, 16);
            label_export.Name = "label_export";
            label_export.Size = new Size(69, 24);
            label_export.TabIndex = 1;
            label_export.Text = "Export";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Pretendard Variable", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label_title.ForeColor = Color.White;
            label_title.Location = new Point(4, 17);
            label_title.Name = "label_title";
            label_title.Size = new Size(172, 19);
            label_title.TabIndex = 2;
            label_title.Text = "Export / Import Images";
            // 
            // button_ok
            // 
            button_ok.BackColor = Color.FromArgb(0, 161, 233);
            button_ok.CornerRadius = 4;
            button_ok.deactivatedColor = Color.LightGray;
            button_ok.FlatAppearance.BorderColor = Color.White;
            button_ok.FlatAppearance.BorderSize = 0;
            button_ok.FlatStyle = FlatStyle.Flat;
            button_ok.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button_ok.ForeColor = Color.White;
            button_ok.Location = new Point(420, 756);
            button_ok.Name = "button_ok";
            button_ok.normalColor = Color.FromArgb(0, 161, 233);
            button_ok.Size = new Size(80, 34);
            button_ok.TabIndex = 4;
            button_ok.Text = "OK";
            button_ok.UseVisualStyleBackColor = false;
            button_ok.Click += button_ok_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.Transparent;
            button_cancel.CornerRadius = 4;
            button_cancel.deactivatedColor = Color.LightGray;
            button_cancel.FlatAppearance.BorderColor = Color.FromArgb(211, 211, 222);
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button_cancel.ForeColor = Color.White;
            button_cancel.Location = new Point(508, 756);
            button_cancel.Name = "button_cancel";
            button_cancel.normalColor = Color.Transparent;
            button_cancel.Size = new Size(80, 34);
            button_cancel.TabIndex = 5;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // Selector_path_import
            // 
            Selector_path_import.BackColor = Color.FromArgb(54, 54, 73);
            Selector_path_import.Location = new Point(16, 58);
            Selector_path_import.Name = "Selector_path_import";
            Selector_path_import.Size = new Size(544, 26);
            Selector_path_import.TabIndex = 13;
            Selector_path_import.Text = "button_Selector1";
            Selector_path_import.Selector_icon = (Image)resources.GetObject("Selector_path_import.Icon");
            Selector_path_import.Text_default = "Select Path";
            // 
            // ExportImportPopupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 73);
            ClientSize = new Size(600, 802);
            ControlBox = false;
            Controls.Add(button_cancel);
            Controls.Add(button_ok);
            Controls.Add(panel_content);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExportImportPopupForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExportImportPopupForm";
            Load += ExportImportPopupForm_Load;
            panel_content.ResumeLayout(false);
            panel_import.ResumeLayout(false);
            panel_import.PerformLayout();
            panel_export.ResumeLayout(false);
            panel_export.PerformLayout();
            panel_export_roi.ResumeLayout(false);
            frame_roi_list.ResumeLayout(false);
            panel_export_options.ResumeLayout(false);
            panel_localpath.ResumeLayout(false);
            panel_localpath.PerformLayout();
            panel_export_ct.ResumeLayout(false);
            panel_export_ct.PerformLayout();
            panel_sampling_rate.ResumeLayout(false);
            panel_sampling_rate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_up).EndInit();
            input_bg_sampling_rate.ResumeLayout(false);
            input_bg_sampling_rate.PerformLayout();
            panel_compress.ResumeLayout(false);
            panel_compress.PerformLayout();
            panel_export_img_type.ResumeLayout(false);
            panel_export_img_type.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_content;
        private Panel panel_import;
        private Label label1;
        private Panel panel_export;
        private RoundedPanel panel_export_roi;
        private Panel frame_roi_list;
        private Panel panel_export_options;
        private Label label_export;
        private Label label_title;
        private Panel panel_export_ct;
        private Panel panel_sampling_rate;
        private Panel panel_compress;
        private Panel panel_export_img_type;
        private Panel panel_localpath;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private SmallCheckBox checkbox_export_nii;
        private SmallCheckBox checkbox_export_stl;
        private Label label8;
        private Label label7;
        private SmallCheckBox checkbox_compress;
        private SmallCheckBox checkbox_export_ct;
        private RoundedPanel input_bg_sampling_rate;
        private PictureBox icon_down;
        private PictureBox icon_up;
        private TextBox textbox_sampling_rate;
        private ROIListControl_Export roiListControl_Export;
        private RoundedButton button_ok;
        private RoundedButton button_cancel;
        private Button_Selector Selector_path_Export;
        private Button_Selector Selector_path_import;
    }
}