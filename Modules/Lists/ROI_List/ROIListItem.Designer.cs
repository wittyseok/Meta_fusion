﻿namespace Metafusion
{
    partial class ROIListItem
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            panel_info = new Panel();
            roi_color = new Panel();
            roi_toggle_icon = new PictureBox();
            roi_name = new TextBox();
            checkbox_bg = new RoundedPanel();
            icon_check = new PictureBox();
            panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roi_toggle_icon).BeginInit();
            checkbox_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_check).BeginInit();
            SuspendLayout();
            // 
            // panel_info
            // 
            panel_info.Controls.Add(roi_color);
            panel_info.Controls.Add(roi_toggle_icon);
            panel_info.Controls.Add(roi_name);
            panel_info.Location = new Point(4, 8);
            panel_info.Name = "panel_info";
            panel_info.Size = new Size(200, 20);
            panel_info.TabIndex = 0;
            // 
            // roi_color
            // 
            roi_color.BackColor = Color.FromArgb(128, 255, 128);
            roi_color.Location = new Point(26, 0);
            roi_color.Name = "roi_color";
            roi_color.Size = new Size(20, 20);
            roi_color.TabIndex = 2;
            roi_color.DoubleClick += roi_color_DoubleClick;
            // 
            // roi_toggle_icon
            // 
            roi_toggle_icon.BackgroundImage = Properties.Resources.icon_toggle_act;
            roi_toggle_icon.BackgroundImageLayout = ImageLayout.Stretch;
            roi_toggle_icon.Location = new Point(0, 0);
            roi_toggle_icon.Name = "roi_toggle_icon";
            roi_toggle_icon.Size = new Size(20, 20);
            roi_toggle_icon.TabIndex = 1;
            roi_toggle_icon.TabStop = false;
            roi_toggle_icon.Click += roi_toggle_icon_Click;
            // 
            // roi_name
            // 
            roi_name.BackColor = Color.FromArgb(33, 33, 44);
            roi_name.BorderStyle = BorderStyle.None;
            roi_name.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            roi_name.ForeColor = Color.FromArgb(240, 240, 244);
            roi_name.ImeMode = ImeMode.NoControl;
            roi_name.Location = new Point(52, 3);
            roi_name.MaxLength = 20;
            roi_name.Name = "roi_name";
            roi_name.ReadOnly = true;
            roi_name.Size = new Size(150, 15);
            roi_name.TabIndex = 0;
            roi_name.Text = "ROI_NAME";
            roi_name.Click += item_Click;
            roi_name.TextChanged += roi_name_TextChanged;
            roi_name.KeyPress += roi_name_KeyPress;
            roi_name.MouseDown += roi_name_Click;
            roi_name.MouseUp += roi_name_Click;
            // 
            // checkbox_bg
            // 
            checkbox_bg.BackColor = Color.FromArgb(31, 186, 255);
            checkbox_bg.borderColor = Color.Red;
            checkbox_bg.BorderWidth = 0;
            checkbox_bg.Controls.Add(icon_check);
            checkbox_bg.CornerRadius = 4;
            checkbox_bg.Location = new Point(240, 10);
            checkbox_bg.Name = "checkbox_bg";
            checkbox_bg.Size = new Size(16, 16);
            checkbox_bg.TabIndex = 4;
            // 
            // icon_check
            // 
            icon_check.BackColor = Color.Transparent;
            icon_check.BackgroundImage = Properties.Resources.icon_check;
            icon_check.BackgroundImageLayout = ImageLayout.Stretch;
            icon_check.Location = new Point(1, 1);
            icon_check.Name = "icon_check";
            icon_check.Size = new Size(14, 14);
            icon_check.TabIndex = 4;
            icon_check.TabStop = false;
            icon_check.Click += icon_check_Click;
            // 
            // ROIListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 44);
            Controls.Add(panel_info);
            Controls.Add(checkbox_bg);
            Name = "ROIListItem";
            Size = new Size(261, 36);
            Load += ROIListItem_Load;
            Click += item_Click;
            panel_info.ResumeLayout(false);
            panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roi_toggle_icon).EndInit();
            checkbox_bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_check).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_info;
        private TextBox roi_name;
        private PictureBox roi_toggle_icon;
        private Panel roi_color;
        private RoundedPanel checkbox_bg;
        private PictureBox icon_check;
    }
}
