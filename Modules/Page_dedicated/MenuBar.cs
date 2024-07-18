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
    public partial class MenuBar : UserControl
    {
        // 이벤트 정의
        public event EventHandler MinimizeClicked;
        public event EventHandler MaximizeClicked;
        public event EventHandler CloseClicked;
        public MenuBar()
        {
            InitializeComponent();
            this.DoubleClick += icon_maximize_Click;
    }

        private void MenuBar_Load(object sender, EventArgs e)
        {

        }
        private void icon_minimize_Click(object sender, EventArgs e)
        {
            // 이벤트 발생
            MinimizeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void icon_maximize_Click(object sender, EventArgs e)
        {
            // 이벤트 발생
            MaximizeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void icon_close_Click(object sender, EventArgs e)
        {
            // 이벤트 발생
            CloseClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
