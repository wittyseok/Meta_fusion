using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Metafusion
{
    public partial class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 4;
        private int borderWidth = 0;
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate(); // 변경 시 화면을 다시 그리도록 합니다.
            }
        }

        public bool ScrollDisabled { get; set; }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x20a && ScrollDisabled) return;
            base.WndProc(ref m);
        }

        public Color borderColor { get; set; } = Color.Red;

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            // 둥근 모서리를 그리는 경로 생성
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, CornerRadius, CornerRadius), 180, 90); //왼쪽 위
            path.AddArc(new Rectangle(this.Width - CornerRadius, 0, CornerRadius, CornerRadius), 270, 90); //오른쪽 위
            path.AddArc(new Rectangle(this.Width - CornerRadius, this.Height - CornerRadius, CornerRadius, CornerRadius), 0, 90); //오른쪽 아래
            path.AddArc(new Rectangle(0, this.Height - CornerRadius, CornerRadius, CornerRadius), 90, 90); //왼쪽 아래
            path.CloseFigure();

            // 패널의 경계 설정
            this.Region = new Region(path);

            // 경계선을 그리는 페인트
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.DrawPath(Pens.Black, path);

            if (borderWidth > 0)
            {
                // 테두리 그리기
                using (Pen pen = new Pen(borderColor, borderWidth))
                {

                    // 둥근 모서리를 그리는 경로 생성
                    GraphicsPath path_inner = new GraphicsPath();
                    path_inner.StartFigure();
                    path_inner.AddArc(new Rectangle(borderWidth, borderWidth, CornerRadius, CornerRadius), 180, 90);
                    path_inner.AddArc(new Rectangle(this.Width - CornerRadius - borderWidth, borderWidth, CornerRadius, CornerRadius), 270, 90);
                    path_inner.AddArc(new Rectangle(this.Width - CornerRadius - borderWidth, this.Height - CornerRadius - borderWidth, CornerRadius, CornerRadius), 0, 90);
                    path_inner.AddArc(new Rectangle(borderWidth, this.Height - CornerRadius - borderWidth, CornerRadius, CornerRadius), 90, 90);
                    path_inner.CloseFigure();
                    // 패널 내부에 테두리를 그립니다.
                    e.Graphics.DrawPath(pen, path_inner);
                }
            }
        }
    }
}