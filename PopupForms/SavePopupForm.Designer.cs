namespace Metafusion
{
    partial class SavePopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavePopupForm));
            label_title = new Label();
            frame_options = new Panel();
            Selector_path = new Button_Selector();
            dropdown_storage = new FlatCombo_Normal();
            input_name_bg = new RoundedPanel();
            textbox_name = new TextBox();
            button_cancel = new RoundedButton();
            button_ok = new RoundedButton();
            frame_options.SuspendLayout();
            input_name_bg.SuspendLayout();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Pretendard Variable", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label_title.ForeColor = Color.White;
            label_title.Location = new Point(16, 16);
            label_title.Name = "label_title";
            label_title.Size = new Size(101, 19);
            label_title.TabIndex = 3;
            label_title.Text = "Save Images";
            label_title.Click += label_title_Click;
            // 
            // frame_options
            // 
            frame_options.Controls.Add(Selector_path);
            frame_options.Controls.Add(dropdown_storage);
            frame_options.Controls.Add(input_name_bg);
            frame_options.Location = new Point(16, 54);
            frame_options.Name = "frame_options";
            frame_options.Size = new Size(344, 94);
            frame_options.TabIndex = 4;
            // 
            // Selector_path
            // 
            Selector_path.BackColor = Color.FromArgb(54, 54, 73);
            Selector_path.Location = new Point(0, 68);
            Selector_path.Name = "Selector_path";
            Selector_path.Selector_icon = (Image)resources.GetObject("Selector_path.Selector_icon");
            Selector_path.Size = new Size(344, 26);
            Selector_path.TabIndex = 11;
            Selector_path.Text = "button_Selector1";
            Selector_path.Text_default = "Select Path";
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
            dropdown_storage.Location = new Point(0, 34);
            dropdown_storage.Name = "dropdown_storage";
            dropdown_storage.Size = new Size(344, 26);
            dropdown_storage.TabIndex = 10;
            dropdown_storage.Text_default = "Select Storage";
            // 
            // input_name_bg
            // 
            input_name_bg.BackColor = Color.FromArgb(240, 240, 244);
            input_name_bg.borderColor = Color.Red;
            input_name_bg.BorderWidth = 0;
            input_name_bg.Controls.Add(textbox_name);
            input_name_bg.CornerRadius = 4;
            input_name_bg.Location = new Point(0, 0);
            input_name_bg.Name = "input_name_bg";
            input_name_bg.ScrollDisabled = false;
            input_name_bg.Size = new Size(344, 26);
            input_name_bg.TabIndex = 7;
            // 
            // textbox_name
            // 
            textbox_name.BackColor = Color.FromArgb(240, 240, 244);
            textbox_name.BorderStyle = BorderStyle.None;
            textbox_name.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textbox_name.Location = new Point(6, 6);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(333, 15);
            textbox_name.TabIndex = 0;
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
            button_cancel.Location = new Point(280, 164);
            button_cancel.Name = "button_cancel";
            button_cancel.normalColor = Color.Transparent;
            button_cancel.Size = new Size(80, 34);
            button_cancel.TabIndex = 7;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
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
            button_ok.Location = new Point(192, 164);
            button_ok.Name = "button_ok";
            button_ok.normalColor = Color.FromArgb(0, 161, 233);
            button_ok.Size = new Size(80, 34);
            button_ok.TabIndex = 6;
            button_ok.Text = "OK";
            button_ok.UseVisualStyleBackColor = false;
            button_ok.Click += button_ok_Click;
            // 
            // SavePopupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 73);
            ClientSize = new Size(376, 214);
            ControlBox = false;
            Controls.Add(button_cancel);
            Controls.Add(button_ok);
            Controls.Add(frame_options);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SavePopupForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SavePopupForm";
            Load += SavePopupForm_Load;
            frame_options.ResumeLayout(false);
            input_name_bg.ResumeLayout(false);
            input_name_bg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Panel frame_options;
        private RoundedButton button_cancel;
        private RoundedButton button_ok;
        private RoundedPanel input_name_bg;
        private TextBox textbox_name;
        private FlatCombo_Normal dropdown_storage;
        private Button_Selector button_select_path;
        private Button_Selector Selector_path;
    }
}