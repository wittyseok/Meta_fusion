using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metafusion
{
    public partial class SavePopupForm : Form
    {
        //features for dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void CustomPopupForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void CustomPopupForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void CustomPopupForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void InitializeDragability()
        {
            this.MouseDown += CustomPopupForm_MouseDown;
            this.MouseMove += CustomPopupForm_MouseMove;
            this.MouseUp += CustomPopupForm_MouseUp;
        }
        //features for dragging

        private bool name_valid = false;
        private bool have_entered = false;
        public SavePopupForm()
        {
            InitializeComponent();
            InitializePlaceholders();
            InitializeDragability();
            this.Select(); //to avoid focus on textbox initially
        }

        private void SavePopupForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }
        private void InitializePlaceholders()
        {
            textbox_name.Enter += RemovePlaceholderText;
            textbox_name.Leave += AddPlaceholderText;
            textbox_name.TextChanged += CheckButton;
            button_ok.Enabled = false;
            SetPlaceholderText(textbox_name, "Name");
        }
        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                have_entered = false;
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void AddPlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrEmpty(textBox.Text))
            {
                if (textBox == textbox_name)
                {
                    SetPlaceholderText(textBox, "Name");
                }
            }
        }
        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            have_entered = true;
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void CheckButton(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox == textbox_name)
                {
                    name_valid = !string.IsNullOrEmpty(textBox.Text)&&have_entered;
                    //todo: if needed, add other name validation process
                }
            }
            button_ok.Enabled = name_valid;
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            //todo: do something before close!
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
