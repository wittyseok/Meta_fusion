namespace Metafusion
{
    partial class ROIListControl_Export
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                // Event handler cleanup
                icon_select_all.Click -= DoSelectAll;
                icon_select_all.MouseDown -= SelectAll_MouseDown;
                icon_select_all.MouseUp -= SelectAll_MouseUp;
                frame_items.Paint -= frame_items_Paint;

                // Dispose items
                foreach (var item in items)
                {
                    item.Dispose();
                }

                items.Clear();

                // Dispose itemsPanel and its children
                if (itemsPanel != null)
                {
                    foreach (Control control in itemsPanel.Controls)
                    {
                        control.Dispose();
                    }
                    itemsPanel.Controls.Clear(); // Optional: Clear the controls collection if needed
                    itemsPanel.Dispose();
                }
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
            panel_select_all = new Panel();
            bg_select_all = new RoundedPanel();
            icon_select_all = new PictureBox();
            label_select_all = new Label();
            frame_items = new Panel();
            panel1 = new Panel();
            panel_select_all.SuspendLayout();
            bg_select_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_select_all).BeginInit();
            SuspendLayout();
            // 
            // panel_select_all
            // 
            panel_select_all.BackColor = Color.FromArgb(54, 54, 73);
            panel_select_all.Controls.Add(bg_select_all);
            panel_select_all.Controls.Add(label_select_all);
            panel_select_all.Location = new Point(0, 0);
            panel_select_all.Name = "panel_select_all";
            panel_select_all.Size = new Size(254, 26);
            panel_select_all.TabIndex = 0;
            panel_select_all.Paint += panel_select_all_Paint;
            // 
            // bg_select_all
            // 
            bg_select_all.BackColor = Color.FromArgb(240, 240, 244);
            bg_select_all.borderColor = Color.Red;
            bg_select_all.BorderWidth = 0;
            bg_select_all.Controls.Add(icon_select_all);
            bg_select_all.CornerRadius = 4;
            bg_select_all.Location = new Point(208, 1);
            bg_select_all.Name = "bg_select_all";
            bg_select_all.Size = new Size(16, 16);
            bg_select_all.TabIndex = 6;
            // 
            // icon_select_all
            // 
            icon_select_all.BackColor = Color.Transparent;
            icon_select_all.BackgroundImage = Properties.Resources.icon_check;
            icon_select_all.BackgroundImageLayout = ImageLayout.Stretch;
            icon_select_all.Location = new Point(1, 1);
            icon_select_all.Name = "icon_select_all";
            icon_select_all.Size = new Size(14, 14);
            icon_select_all.TabIndex = 4;
            icon_select_all.TabStop = false;
            // 
            // label_select_all
            // 
            label_select_all.AutoSize = true;
            label_select_all.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label_select_all.ForeColor = Color.White;
            label_select_all.Location = new Point(0, 1);
            label_select_all.Name = "label_select_all";
            label_select_all.Size = new Size(58, 14);
            label_select_all.TabIndex = 1;
            label_select_all.Text = "Select All";
            // 
            // frame_items
            // 
            frame_items.BackColor = Color.Transparent;
            frame_items.Location = new Point(8, 34);
            frame_items.Name = "frame_items";
            frame_items.Size = new Size(246, 458);
            frame_items.TabIndex = 1;
            frame_items.Paint += frame_items_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 73);
            panel1.Location = new Point(240, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(14, 458);
            panel1.TabIndex = 2;
            // 
            // ROIListControl_Export
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(frame_items);
            Controls.Add(panel1);
            Controls.Add(panel_select_all);
            Name = "ROIListControl_Export";
            Size = new Size(254, 484);
            panel_select_all.ResumeLayout(false);
            panel_select_all.PerformLayout();
            bg_select_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_select_all).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_select_all;
        private Label label_select_all;
        private RoundedPanel bg_select_all;
        private PictureBox icon_select_all;
        private Panel frame_items;
        private Panel panel1;
    }
}
