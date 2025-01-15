using System.Runtime.InteropServices;
using RTCV.Common;

namespace RTCV.UI
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using RTCV.UI.Modular;

    #pragma warning disable CA2213 //Component designer classes generate their own Dispose method
    public partial class ComponentFormTile : ColorizedForm, ITileForm
    {
        [DllImport("user32.dll")]
        private static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, UIntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const uint WM_SYSCOMMAND = 0x112;
        private const uint MOUSE_MOVE = 0xF012;
        
        private const int DragPopoutThreshold = 15;
        
        public Form ChildForm { get; private set; } = null;
        private int _sizeX = 2;
        private int _sizeY = 2;

        public ComponentFormTile()
        {
            InitializeComponent();
        }

        internal void SetComponentForm(Form childForm, int sizeX, int sizeY, bool displayHeader)
        {
            ChildForm = childForm;
            _sizeX = sizeX;
            _sizeY = sizeY;

            this.Size = new Size(
                (_sizeX * CanvasForm.tileSize) + ((_sizeX - 1) * CanvasForm.spacerSize),
                (_sizeY * CanvasForm.tileSize) + ((_sizeY - 1) * CanvasForm.spacerSize)
                );

            if (ChildForm is ComponentForm cf)
            {
                cf.AnchorToPanel(pnComponentFormHost);
                cf.ParentComponentFormTitle = this;
            }

            if (displayHeader)
            {
                lbComponentFormName.Text = ChildForm.Text; // replace that with the childform's text property
            }
            else
            {
                lbComponentFormName.Visible = false;
                pnComponentFormHost.Location = new Point(0, 0);
                pnComponentFormHost.Size = this.Size;
                ChildForm.Size = this.Size;
            }
        }

        public bool CanPopout { get; set; } = false;
        public int TilesX { get => _sizeX; set => _sizeX = value; }
        public int TilesY { get => _sizeY; set => _sizeY = value; }
        private Point _mouseDownAt = new Point(int.MinValue);
        
        private void OnFormTileMouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y - pnComponentFormHost.Location.Y);
            var ea = new MouseEventArgs(e.Button, e.Clicks, p.X, p.Y, e.Delta);
            (ChildForm as ComponentForm)?.HandleMouseDown(ChildForm, ea);

            if (e.Button != MouseButtons.Left)
                return;
            
            _mouseDownAt = new Point(e.X, e.Y);
            
            
            if (!((ComponentForm)ChildForm).PopoutAllowed)
            {
                ((Control)sender).Cursor = Cursors.No;
            }
        }

        private void OnFormTileMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !((ComponentForm)ChildForm).PopoutAllowed)
            {
                ((Control)sender).Cursor = Cursors.Default;
            }
        }

        private void OnFormTileMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            var cf = (ComponentForm)ChildForm;
            if (!cf.PopoutAllowed)
                return;

            Point p = new Point(Math.Abs(e.X - _mouseDownAt.X), Math.Abs(e.Y - _mouseDownAt.Y));
            bool stillDocked = pnComponentFormHost.Controls.Contains(ChildForm);
            if (p.X < DragPopoutThreshold && p.Y < DragPopoutThreshold && stillDocked)
                return;

            if (stillDocked)
            {
                cf.SwitchToWindow();
                ChildForm.Location = PointToScreen(e.Location - new Size(_mouseDownAt));
                ReleaseCapture();
                DefWindowProc(ChildForm.Handle, WM_SYSCOMMAND, (UIntPtr)MOUSE_MOVE, IntPtr.Zero);
            }
        }

        public void ReAnchorToPanel()
        {
            var cf = (ChildForm as ComponentForm);

            if (cf != null)
            {
                cf.AnchorToPanel(pnComponentFormHost);
                cf.Size = pnComponentFormHost.Size;
                this.Anchor = cf.Anchor;
            }
        }

        private void lbComponentFormName_MouseMove(object sender, MouseEventArgs e)
        {
            OnFormTileMouseMove(sender, e);
        }
    }

    public class ComponentPanel : Panel
    {
    }
}
