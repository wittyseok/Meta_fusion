namespace Metafusion
{
    partial class NavBarUserControl
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
            button_backplate = new Panel();
            button_item3 = new Panel();
            label_item3 = new Label();
            panel_item3 = new Panel();
            button_viewer = new Panel();
            label_viewer = new Label();
            panel_viewer = new Panel();
            button_itemtooth = new Panel();
            label_itemtooth = new Label();
            panel_itemtooth = new Panel();
            button_item5 = new Panel();
            label_item5 = new Label();
            panel_item5 = new Panel();
            button_item1 = new Panel();
            label_item1 = new Label();
            panel_item1 = new Panel();
            button_home = new Panel();
            label_home = new Label();
            panel_home = new Panel();
            button_backplate.SuspendLayout();
            button_item3.SuspendLayout();
            button_viewer.SuspendLayout();
            button_itemtooth.SuspendLayout();
            button_item5.SuspendLayout();
            button_item1.SuspendLayout();
            button_home.SuspendLayout();
            SuspendLayout();
            // 
            // button_backplate
            // 
            button_backplate.BackColor = Color.Black;
            button_backplate.Controls.Add(button_item3);
            button_backplate.Controls.Add(button_viewer);
            button_backplate.Controls.Add(button_itemtooth);
            button_backplate.Controls.Add(button_item5);
            button_backplate.Controls.Add(button_item1);
            button_backplate.Controls.Add(button_home);
            button_backplate.Location = new Point(0, 0);
            button_backplate.Name = "button_backplate";
            button_backplate.Size = new Size(683, 37);
            button_backplate.TabIndex = 1;
            // 
            // button_item3
            // 
            button_item3.BackColor = Color.FromArgb(98, 98, 132);
            button_item3.Controls.Add(label_item3);
            button_item3.Controls.Add(panel_item3);
            button_item3.ForeColor = SystemColors.ControlText;
            button_item3.Location = new Point(209, 0);
            button_item3.Name = "button_item3";
            button_item3.Size = new Size(106, 37);
            button_item3.TabIndex = 5;
            button_item3.Paint += button_item3_Paint;
            // 
            // label_item3
            // 
            label_item3.AutoSize = true;
            label_item3.BackColor = Color.Transparent;
            label_item3.Font = new Font("Pretendard Variable Medium", 10F);
            label_item3.ForeColor = Color.FromArgb(152, 152, 179);
            label_item3.Location = new Point(29, 9);
            label_item3.Name = "label_item3";
            label_item3.Size = new Size(48, 16);
            label_item3.TabIndex = 3;
            label_item3.Text = "ITEM3";
            label_item3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_item3
            // 
            panel_item3.BackColor = Color.FromArgb(152, 152, 179);
            panel_item3.ForeColor = SystemColors.ControlText;
            panel_item3.Location = new Point(0, 33);
            panel_item3.Name = "panel_item3";
            panel_item3.Size = new Size(106, 4);
            panel_item3.TabIndex = 2;
            // 
            // button_viewer
            // 
            button_viewer.BackColor = Color.FromArgb(98, 98, 132);
            button_viewer.Controls.Add(label_viewer);
            button_viewer.Controls.Add(panel_viewer);
            button_viewer.ForeColor = SystemColors.ControlText;
            button_viewer.Location = new Point(567, 0);
            button_viewer.Name = "button_viewer";
            button_viewer.Size = new Size(114, 37);
            button_viewer.TabIndex = 4;
            // 
            // label_viewer
            // 
            label_viewer.AutoSize = true;
            label_viewer.BackColor = Color.Transparent;
            label_viewer.Font = new Font("Pretendard Variable Medium", 10F);
            label_viewer.ForeColor = Color.FromArgb(152, 152, 179);
            label_viewer.Location = new Point(29, 9);
            label_viewer.Name = "label_viewer";
            label_viewer.Size = new Size(57, 16);
            label_viewer.TabIndex = 3;
            label_viewer.Text = "VIEWER";
            label_viewer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_viewer
            // 
            panel_viewer.BackColor = Color.FromArgb(152, 152, 179);
            panel_viewer.ForeColor = SystemColors.ControlText;
            panel_viewer.Location = new Point(0, 33);
            panel_viewer.Name = "panel_viewer";
            panel_viewer.Size = new Size(114, 4);
            panel_viewer.TabIndex = 2;
            // 
            // button_itemtooth
            // 
            button_itemtooth.BackColor = Color.FromArgb(98, 98, 132);
            button_itemtooth.Controls.Add(label_itemtooth);
            button_itemtooth.Controls.Add(panel_itemtooth);
            button_itemtooth.ForeColor = SystemColors.ControlText;
            button_itemtooth.Location = new Point(422, 0);
            button_itemtooth.Name = "button_itemtooth";
            button_itemtooth.Size = new Size(145, 37);
            button_itemtooth.TabIndex = 3;
            // 
            // label_itemtooth
            // 
            label_itemtooth.AutoSize = true;
            label_itemtooth.BackColor = Color.Transparent;
            label_itemtooth.Font = new Font("Pretendard Variable Medium", 10F);
            label_itemtooth.ForeColor = Color.FromArgb(152, 152, 179);
            label_itemtooth.Location = new Point(29, 9);
            label_itemtooth.Name = "label_itemtooth";
            label_itemtooth.Size = new Size(91, 16);
            label_itemtooth.TabIndex = 3;
            label_itemtooth.Text = "ITEM TOOTH";
            label_itemtooth.TextAlign = ContentAlignment.MiddleCenter;
            label_itemtooth.Click += label_itemtooth_Click;
            // 
            // panel_itemtooth
            // 
            panel_itemtooth.BackColor = Color.FromArgb(152, 152, 179);
            panel_itemtooth.ForeColor = SystemColors.ControlText;
            panel_itemtooth.Location = new Point(0, 33);
            panel_itemtooth.Name = "panel_itemtooth";
            panel_itemtooth.Size = new Size(145, 4);
            panel_itemtooth.TabIndex = 2;
            // 
            // button_item5
            // 
            button_item5.BackColor = Color.FromArgb(98, 98, 132);
            button_item5.Controls.Add(label_item5);
            button_item5.Controls.Add(panel_item5);
            button_item5.ForeColor = SystemColors.ControlText;
            button_item5.Location = new Point(315, 0);
            button_item5.Name = "button_item5";
            button_item5.Size = new Size(107, 37);
            button_item5.TabIndex = 2;
            // 
            // label_item5
            // 
            label_item5.AutoSize = true;
            label_item5.BackColor = Color.Transparent;
            label_item5.Font = new Font("Pretendard Variable Medium", 10F);
            label_item5.ForeColor = Color.FromArgb(152, 152, 179);
            label_item5.Location = new Point(29, 9);
            label_item5.Name = "label_item5";
            label_item5.Size = new Size(47, 16);
            label_item5.TabIndex = 3;
            label_item5.Text = "ITEM5";
            label_item5.TextAlign = ContentAlignment.MiddleCenter;
            label_item5.Click += label_item5_Click;
            // 
            // panel_item5
            // 
            panel_item5.BackColor = Color.FromArgb(152, 152, 179);
            panel_item5.ForeColor = SystemColors.ControlText;
            panel_item5.Location = new Point(0, 33);
            panel_item5.Name = "panel_item5";
            panel_item5.Size = new Size(107, 4);
            panel_item5.TabIndex = 2;
            // 
            // button_item1
            // 
            button_item1.BackColor = Color.FromArgb(98, 98, 132);
            button_item1.Controls.Add(label_item1);
            button_item1.Controls.Add(panel_item1);
            button_item1.ForeColor = SystemColors.ControlText;
            button_item1.Location = new Point(104, 0);
            button_item1.Name = "button_item1";
            button_item1.Size = new Size(105, 37);
            button_item1.TabIndex = 1;
            button_item1.Paint += button_item1_Paint;
            // 
            // label_item1
            // 
            label_item1.AutoSize = true;
            label_item1.BackColor = Color.Transparent;
            label_item1.Font = new Font("Pretendard Variable Medium", 10F);
            label_item1.ForeColor = Color.FromArgb(152, 152, 179);
            label_item1.Location = new Point(29, 9);
            label_item1.Name = "label_item1";
            label_item1.Size = new Size(45, 16);
            label_item1.TabIndex = 3;
            label_item1.Text = "ITEM1";
            label_item1.TextAlign = ContentAlignment.MiddleCenter;
            label_item1.Click += label_item1_Click;
            // 
            // panel_item1
            // 
            panel_item1.BackColor = Color.FromArgb(152, 152, 179);
            panel_item1.ForeColor = SystemColors.ControlText;
            panel_item1.Location = new Point(0, 33);
            panel_item1.Name = "panel_item1";
            panel_item1.Size = new Size(105, 4);
            panel_item1.TabIndex = 2;
            // 
            // button_home
            // 
            button_home.BackColor = Color.FromArgb(98, 98, 132);
            button_home.Controls.Add(label_home);
            button_home.Controls.Add(panel_home);
            button_home.ForeColor = SystemColors.ControlText;
            button_home.Location = new Point(0, 0);
            button_home.Name = "button_home";
            button_home.Size = new Size(104, 37);
            button_home.TabIndex = 0;
            // 
            // label_home
            // 
            label_home.AutoSize = true;
            label_home.BackColor = Color.Transparent;
            label_home.Font = new Font("Pretendard Variable Medium", 10F);
            label_home.ForeColor = Color.FromArgb(152, 152, 179);
            label_home.Location = new Point(29, 9);
            label_home.Name = "label_home";
            label_home.Size = new Size(47, 16);
            label_home.TabIndex = 3;
            label_home.Text = "HOME";
            label_home.TextAlign = ContentAlignment.MiddleCenter;
            label_home.Click += label_home_Click;
            // 
            // panel_home
            // 
            panel_home.BackColor = Color.FromArgb(152, 152, 179);
            panel_home.ForeColor = SystemColors.ControlText;
            panel_home.Location = new Point(0, 33);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(104, 4);
            panel_home.TabIndex = 2;
            // 
            // NavBarUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_backplate);
            Name = "NavBarUserControl";
            Size = new Size(683, 37);
            button_backplate.ResumeLayout(false);
            button_item3.ResumeLayout(false);
            button_item3.PerformLayout();
            button_viewer.ResumeLayout(false);
            button_viewer.PerformLayout();
            button_itemtooth.ResumeLayout(false);
            button_itemtooth.PerformLayout();
            button_item5.ResumeLayout(false);
            button_item5.PerformLayout();
            button_item1.ResumeLayout(false);
            button_item1.PerformLayout();
            button_home.ResumeLayout(false);
            button_home.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel button_backplate;
        private Panel button_item3;
        private Label label_item3;
        private Panel panel_item3;
        private Panel button_viewer;
        private Label label_viewer;
        private Panel panel_viewer;
        private Panel button_itemtooth;
        private Label label_itemtooth;
        private Panel panel_itemtooth;
        private Panel button_item5;
        private Label label_item5;
        private Panel panel_item5;
        private Panel button_item1;
        private Label label_item1;
        private Panel panel_item1;
        private Panel button_home;
        private Label label_home;
        private Panel panel_home;
    }
}
