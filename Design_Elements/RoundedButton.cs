using System;
using System.Drawing.Drawing2D;
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
    public partial class RoundedButton : Button
    {
        public int CornerRadius { get; set; } = 4;

        private bool isMousePressed = false;
        public Color normalColor { get; set; } = SystemColors.Control;
        public Color deactivatedColor { get; set; } = Color.LightGray;


        public RoundedButton()
        {
            // MouseDown 이벤트와 MouseUp 이벤트를 핸들링할 이벤트 핸들러를 등록합니다.
            this.MouseDown += RoundedButton_MouseDown;
            this.MouseUp += RoundedButton_MouseUp;
            this.MouseLeave += RoundedButton_MouseLeave;
            this.EnabledChanged += RoundedButton_EnabledChanged;

        }

        private void RoundedButton_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressed = true;
            Invalidate();
        }

        private void RoundedButton_EnabledChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void RoundedButton_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
            Invalidate();
        }

        private void RoundedButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = normalColor;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            int radius = CornerRadius;

            if (Enabled)
            {
                BackColor = normalColor;
            }
            else
            {
                BackColor = deactivatedColor;
            }

            if (isMousePressed)
            {
                // 클릭된 상태일 때 버튼의 모양을 둥글게 그립니다.
                grPath.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // Top-left corner
                grPath.AddArc(ClientSize.Width - 2 * radius, 0, radius * 2, radius * 2, 270, 90); // Top-right corner
                grPath.AddArc(ClientSize.Width - 2 * radius, ClientSize.Height - 2 * radius, radius * 2, radius * 2, 0, 90); // Bottom-right corner
                grPath.AddArc(0, ClientSize.Height - 2 * radius, radius * 2, radius * 2, 90, 90); // Bottom-left corner
                grPath.CloseFigure();
                this.Region = new Region(grPath);
                base.OnPaint(e);
            }
            else
            {
                // 클릭되지 않은 상태일 때
                grPath.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // Top-left corner
                grPath.AddArc(ClientSize.Width - 2 * radius, 0, radius * 2, radius * 2, 270, 90); // Top-right corner
                grPath.AddArc(ClientSize.Width - 2 * radius, ClientSize.Height - 2 * radius, radius * 2, radius * 2, 0, 90); // Bottom-right corner
                grPath.AddArc(0, ClientSize.Height - 2 * radius, radius * 2, radius * 2, 90, 90); // Bottom-left corner
                grPath.CloseFigure();
                this.Region = new Region(grPath);
                base.OnPaint(e);
            }
            if (this.FlatAppearance.BorderSize > 0)
            {
                Graphics graphics = e.Graphics;
                // 테두리 그리기
                using (Pen pen = new Pen(this.FlatAppearance.BorderColor, this.FlatAppearance.BorderSize))
                {
                    graphics.DrawPath(pen, grPath);
                }
            }
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = CornerRadius;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left corner
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right corner
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left corner
            path.CloseFigure();

            return path;
        }
    }
}