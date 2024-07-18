namespace Metafusion.Modules.Page_dedicated.Home
{
    partial class SelectFunctionControl
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
            panel_bg = new RoundedPanel();
            Button_viewer = new RoundedButton();
            Button_itemtooth = new RoundedButton();
            Button_item3 = new RoundedButton();
            Button_item5 = new RoundedButton();
            Button_item1 = new RoundedButton();
            panel_bg.SuspendLayout();
            SuspendLayout();
            // 
            // panel_bg
            // 
            panel_bg.BackColor = Color.FromArgb(54, 54, 73);
            panel_bg.borderColor = Color.Red;
            panel_bg.BorderWidth = 0;
            panel_bg.Controls.Add(Button_viewer);
            panel_bg.Controls.Add(Button_itemtooth);
            panel_bg.Controls.Add(Button_item3);
            panel_bg.Controls.Add(Button_item5);
            panel_bg.Controls.Add(Button_item1);
            panel_bg.CornerRadius = 4;
            panel_bg.Location = new Point(0, 0);
            panel_bg.Name = "panel_bg";
            panel_bg.ScrollDisabled = false;
            panel_bg.Size = new Size(240, 250);
            panel_bg.TabIndex = 1;
            // 
            // Button_viewer
            // 
            Button_viewer.BackColor = Color.FromArgb(0, 161, 233);
            Button_viewer.CornerRadius = 4;
            Button_viewer.deactivatedColor = Color.LightGray;
            Button_viewer.FlatAppearance.BorderColor = Color.White;
            Button_viewer.FlatAppearance.BorderSize = 0;
            Button_viewer.FlatStyle = FlatStyle.Flat;
            Button_viewer.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Button_viewer.ForeColor = Color.White;
            Button_viewer.Location = new Point(8, 208);
            Button_viewer.Name = "Button_viewer";
            Button_viewer.normalColor = Color.FromArgb(0, 161, 233);
            Button_viewer.Size = new Size(224, 34);
            Button_viewer.TabIndex = 24;
            Button_viewer.Text = "Viewer";
            Button_viewer.TextAlign = ContentAlignment.MiddleLeft;
            Button_viewer.UseVisualStyleBackColor = false;
            // 
            // Button_itemtooth
            // 
            Button_itemtooth.BackColor = Color.FromArgb(0, 161, 233);
            Button_itemtooth.CornerRadius = 4;
            Button_itemtooth.deactivatedColor = Color.LightGray;
            Button_itemtooth.FlatAppearance.BorderColor = Color.White;
            Button_itemtooth.FlatAppearance.BorderSize = 0;
            Button_itemtooth.FlatStyle = FlatStyle.Flat;
            Button_itemtooth.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Button_itemtooth.ForeColor = Color.White;
            Button_itemtooth.Location = new Point(8, 158);
            Button_itemtooth.Name = "Button_itemtooth";
            Button_itemtooth.normalColor = Color.FromArgb(0, 161, 233);
            Button_itemtooth.Size = new Size(224, 34);
            Button_itemtooth.TabIndex = 23;
            Button_itemtooth.Text = "Osteonecrosis of the jaw Evaluation";
            Button_itemtooth.TextAlign = ContentAlignment.MiddleLeft;
            Button_itemtooth.UseVisualStyleBackColor = false;
            // 
            // Button_item3
            // 
            Button_item3.BackColor = Color.FromArgb(0, 161, 233);
            Button_item3.CornerRadius = 4;
            Button_item3.deactivatedColor = Color.LightGray;
            Button_item3.FlatAppearance.BorderColor = Color.White;
            Button_item3.FlatAppearance.BorderSize = 0;
            Button_item3.FlatStyle = FlatStyle.Flat;
            Button_item3.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Button_item3.ForeColor = Color.White;
            Button_item3.Location = new Point(8, 58);
            Button_item3.Name = "Button_item3";
            Button_item3.normalColor = Color.FromArgb(0, 161, 233);
            Button_item3.Size = new Size(224, 34);
            Button_item3.TabIndex = 22;
            Button_item3.Text = "Normal Organ Segmentation";
            Button_item3.TextAlign = ContentAlignment.MiddleLeft;
            Button_item3.UseVisualStyleBackColor = false;
            // 
            // Button_item5
            // 
            Button_item5.BackColor = Color.FromArgb(0, 161, 233);
            Button_item5.CornerRadius = 4;
            Button_item5.deactivatedColor = Color.LightGray;
            Button_item5.FlatAppearance.BorderColor = Color.White;
            Button_item5.FlatAppearance.BorderSize = 0;
            Button_item5.FlatStyle = FlatStyle.Flat;
            Button_item5.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_item5.ForeColor = Color.White;
            Button_item5.Location = new Point(8, 108);
            Button_item5.Name = "Button_item5";
            Button_item5.normalColor = Color.FromArgb(0, 161, 233);
            Button_item5.Size = new Size(224, 34);
            Button_item5.TabIndex = 21;
            Button_item5.Text = "Medical Image Processing && Viewer";
            Button_item5.TextAlign = ContentAlignment.MiddleLeft;
            Button_item5.UseVisualStyleBackColor = false;
            // 
            // Button_item1
            // 
            Button_item1.BackColor = Color.FromArgb(0, 161, 233);
            Button_item1.CornerRadius = 4;
            Button_item1.deactivatedColor = Color.LightGray;
            Button_item1.FlatAppearance.BorderColor = Color.White;
            Button_item1.FlatAppearance.BorderSize = 0;
            Button_item1.FlatStyle = FlatStyle.Flat;
            Button_item1.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Button_item1.ForeColor = Color.White;
            Button_item1.Location = new Point(8, 8);
            Button_item1.Name = "Button_item1";
            Button_item1.normalColor = Color.FromArgb(0, 161, 233);
            Button_item1.Size = new Size(224, 34);
            Button_item1.TabIndex = 20;
            Button_item1.Text = "SUV Analysis";
            Button_item1.TextAlign = ContentAlignment.MiddleLeft;
            Button_item1.UseVisualStyleBackColor = false;
            // 
            // SelectFunctionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 44);
            Controls.Add(panel_bg);
            Name = "SelectFunctionControl";
            Size = new Size(240, 250);
            panel_bg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panel_bg;
        private RoundedButton Button_item1;
        private RoundedButton Button_viewer;
        private RoundedButton Button_itemtooth;
        private RoundedButton Button_item3;
        private RoundedButton Button_item5;
    }
}
