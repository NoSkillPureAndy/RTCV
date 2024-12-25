namespace RTCV.UI
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using RTCV.UI.Modular;

    #pragma warning disable CA2213 //Component designer classes generate their own Dispose method
    public partial class ComponentFormTile : ColorizedForm, ITileForm
    {
        public Form childForm { get; private set; } = null;
        private int SizeX = 2;
        private int SizeY = 2;

        public ComponentFormTile()
        {
            InitializeComponent();
        }

        internal void SetComponentForm(Form _childForm, int _sizeX, int _sizeY, bool DisplayHeader)
        {
            childForm = _childForm;
            SizeX = _sizeX;
            SizeY = _sizeY;

            this.Size = new Size(
                (SizeX * CanvasForm.tileSize) + ((SizeX - 1) * CanvasForm.spacerSize),
                (SizeY * CanvasForm.tileSize) + ((SizeY - 1) * CanvasForm.spacerSize)
                );

            if (childForm is ComponentForm cf)
            {
                cf.AnchorToPanel(pnComponentFormHost);
                cf.ParentComponentFormTitle = this;
            }

            if (DisplayHeader)
            {
                lbComponentFormName.Text = childForm.Text; // replace that with the childform's text property
            }
            else
            {
                lbComponentFormName.Visible = false;
                pnComponentFormHost.Location = new Point(0, 0);
                pnComponentFormHost.Size = this.Size;
                childForm.Size = this.Size;
            }
        }

        public bool CanPopout { get; set; } = false;
        public int TilesX { get => SizeX; set => SizeX = value; }
        public int TilesY { get => SizeY; set => SizeY = value; }
        private Point _mouseDownAt = new Point(int.MinValue);

        private void OnFormTileMouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y - pnComponentFormHost.Location.Y);
            var ea = new MouseEventArgs(e.Button, e.Clicks, p.X, p.Y, e.Delta);
            (childForm as ComponentForm)?.HandleMouseDown(childForm, ea);
            
            if (e.Button == MouseButtons.Left)
                _mouseDownAt = new Point(e.X, e.Y);
        }

        private void OnFormTileMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            var cf = childForm as ComponentForm;
            if (!cf.popoutAllowed)
                return;

            Point p = new Point(Math.Abs(e.X - _mouseDownAt.X), Math.Abs(e.Y - _mouseDownAt.Y));
            bool stillDocked = pnComponentFormHost.Controls.Contains(childForm);
            if (p.X < 15 && p.Y < 15 && stillDocked)
                return;

            if (stillDocked)
                cf.SwitchToWindow();
            
            childForm.Location = PointToScreen(e.Location - new Size(_mouseDownAt));
        }

        public void ReAnchorToPanel()
        {
            var cf = (childForm as ComponentForm);

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
