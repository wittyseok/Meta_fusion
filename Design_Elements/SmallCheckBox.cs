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
    public partial class SmallCheckBox : UserControl
    {
        private bool _is_checked = true;
        public bool is_checked
        {
            get { return _is_checked; }
            set
            {
                _is_checked = value;
                if (is_checked)
                {
                    bg_select_all.BackColor = Color.FromArgb(31, 186, 255);
                }
                else
                {
                    bg_select_all.BackColor = Color.FromArgb(240, 240, 244);
                }
            }
        }
        public SmallCheckBox()
        {
            InitializeComponent();
        }

        private void icon_check_Click(object sender, EventArgs e)
        {
            is_checked = !is_checked;
        }
    }
}
