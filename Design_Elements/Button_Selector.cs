using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metafusion
{
    public partial class Button_Selector : Control
    {
        private String text_default;
        public String Text_default
        {
            get { return text_default; }
            set
            {
                if (text_default != value)
                {
                    text_default = value;
                    this.text_display.Text = text_default;
                    this.text_display.Location = new Point(8, 5);
                    Invalidate();
                }
            }
        }

        private Image icon;
        public Image Selector_icon
        {
            get { return icon; }
            set
            {
                if (icon != value)
                {
                    icon = value;
                    this.icon_display.BackgroundImage = icon;
                    this.icon_display.Location = new Point(panel_background.Width - 24, 5);
                    Invalidate();
                }
            }
        }

        public Button_Selector()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            this.icon_display.Location = new Point(panel_background.Width - 24, 5);
            base.OnPaint(pe);
        }

        private void panel_background_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
