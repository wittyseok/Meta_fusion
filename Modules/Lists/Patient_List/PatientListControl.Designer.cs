using System.Windows.Forms;

namespace Metafusion
{
    partial class PatientListControl
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

                // Dispose items
                foreach (var item in theUCs)
                {
                    item.Dispose();
                }

                theUCs.Clear();

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
            panel7 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            label8 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel_PatientID = new Panel();
            label_PatientID = new Label();
            bg_select_all = new RoundedPanel();
            icon_select_all = new PictureBox();
            panel9 = new Panel();
            frame_items = new Panel();
            panel_select_all.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel_PatientID.SuspendLayout();
            bg_select_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_select_all).BeginInit();
            SuspendLayout();
            // 
            // panel_select_all
            // 
            panel_select_all.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_select_all.BackColor = Color.FromArgb(54, 54, 73);
            panel_select_all.Controls.Add(panel7);
            panel_select_all.Controls.Add(panel8);
            panel_select_all.Controls.Add(panel6);
            panel_select_all.Controls.Add(panel4);
            panel_select_all.Controls.Add(panel2);
            panel_select_all.Controls.Add(panel3);
            panel_select_all.Controls.Add(panel5);
            panel_select_all.Controls.Add(panel1);
            panel_select_all.Controls.Add(panel_PatientID);
            panel_select_all.Controls.Add(bg_select_all);
            panel_select_all.Controls.Add(panel9);
            panel_select_all.Location = new Point(0, 0);
            panel_select_all.Name = "panel_select_all";
            panel_select_all.Size = new Size(1459, 29);
            panel_select_all.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(1302, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(158, 29);
            panel7.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.White;
            label7.Location = new Point(46, 6);
            label7.Name = "label7";
            label7.Size = new Size(66, 14);
            label7.TabIndex = 9;
            label7.Text = "Study Date";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(label8);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(1144, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(158, 29);
            panel8.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.ForeColor = Color.White;
            label8.Location = new Point(28, 6);
            label8.Name = "label8";
            label8.Size = new Size(103, 14);
            label8.TabIndex = 9;
            label8.Text = "Study Description";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(986, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(158, 29);
            panel6.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.ForeColor = Color.White;
            label6.Location = new Point(44, 6);
            label6.Name = "label6";
            label6.Size = new Size(71, 14);
            label6.TabIndex = 9;
            label6.Text = "Series Time";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(828, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(158, 29);
            panel4.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 6);
            label4.Name = "label4";
            label4.Size = new Size(69, 14);
            label4.TabIndex = 9;
            label4.Text = "Series Date";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(670, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 29);
            panel2.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 6);
            label2.Name = "label2";
            label2.Size = new Size(106, 14);
            label2.TabIndex = 9;
            label2.Text = "Series Description";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(512, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 29);
            panel3.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 6);
            label3.Name = "label3";
            label3.Size = new Size(53, 14);
            label3.TabIndex = 9;
            label3.Text = "Modality";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(354, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(158, 29);
            panel5.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.White;
            label5.Location = new Point(55, 6);
            label5.Name = "label5";
            label5.Size = new Size(49, 14);
            label5.TabIndex = 9;
            label5.Text = "Storage";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(196, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 29);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 6);
            label1.Name = "label1";
            label1.Size = new Size(80, 14);
            label1.TabIndex = 9;
            label1.Text = "Patient Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_PatientID
            // 
            panel_PatientID.Controls.Add(label_PatientID);
            panel_PatientID.Dock = DockStyle.Left;
            panel_PatientID.Location = new Point(38, 0);
            panel_PatientID.Name = "panel_PatientID";
            panel_PatientID.Size = new Size(158, 29);
            panel_PatientID.TabIndex = 21;
            // 
            // label_PatientID
            // 
            label_PatientID.AutoSize = true;
            label_PatientID.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label_PatientID.ForeColor = Color.White;
            label_PatientID.Location = new Point(50, 6);
            label_PatientID.Name = "label_PatientID";
            label_PatientID.Size = new Size(59, 14);
            label_PatientID.TabIndex = 9;
            label_PatientID.Text = "Patient ID";
            label_PatientID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bg_select_all
            // 
            bg_select_all.BackColor = Color.FromArgb(240, 240, 244);
            bg_select_all.borderColor = Color.Red;
            bg_select_all.BorderWidth = 0;
            bg_select_all.Controls.Add(icon_select_all);
            bg_select_all.CornerRadius = 4;
            bg_select_all.Location = new Point(12, 5);
            bg_select_all.Name = "bg_select_all";
            bg_select_all.Size = new Size(16, 16);
            bg_select_all.TabIndex = 17;
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
            // panel9
            // 
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(38, 29);
            panel9.TabIndex = 20;
            // 
            // frame_items
            // 
            frame_items.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_items.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_items.BackColor = Color.Black;
            frame_items.Location = new Point(0, 29);
            frame_items.Name = "frame_items";
            frame_items.Size = new Size(1459, 896);
            frame_items.TabIndex = 1;
            // 
            // PatientListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(frame_items);
            Controls.Add(panel_select_all);
            Name = "PatientListControl";
            Size = new Size(1459, 925);
            SizeChanged += PatientListControl_SizeChanged;
            panel_select_all.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_PatientID.ResumeLayout(false);
            panel_PatientID.PerformLayout();
            bg_select_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_select_all).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_select_all;
        private RoundedPanel bg_select_all;
        private Panel frame_items;
        private PictureBox icon_select_all;
        private Panel panel9;
        private Panel panel_PatientID;
        private Label label_PatientID;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Panel panel6;
        private Label label6;
        private Panel panel4;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel5;
        private Label label5;
        private Panel panel1;
        private Label label1;
    }
}
