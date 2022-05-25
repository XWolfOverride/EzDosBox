using EzDosBox.i18n;

namespace EzDosBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip.SetToolTip(btAdd, Lang.Current.labelAdd);
            toolTip.SetToolTip(btRemove, Lang.Current.labelRemove);
            toolTip.SetToolTip(btConfig, Lang.Current.labelSettings);

            Refreshlist();
        }

        private void Refreshlist()
        {
            lbItems.Items.Clear();
            lbItems.Items.AddRange(Game.List);
        }

        private void ShowDetails(Game? g)
        {
            if (g == null)
            {
                pinfo.Visible = false;
            }
            else
            if (g.Image == null)
            {
                Relocate(false);
            }
            else
            {
                pbImage.Image = g.Image;
                Relocate(true);
            }
        }

        private void Relocate(bool? showImage = null)
        {
            bool simg = showImage ?? pbImage.Visible;
            int wid = pinfo.ClientSize.Width;
            if (simg)
            {
                pbImage.Width = wid;
                pbImage.Height = (pbImage.Width * 3) / 4;
            }
            else
                pbImage.Height = 0;
            pbImage.Visible = simg;
        }

        private static void Run(Game g)
        {
            g.Run();
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            FSettings.Execute();
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetails(lbItems.SelectedItem as Game);

        }

        private void lbItems_DoubleClick(object sender, EventArgs e)
        {
            if (lbItems.SelectedItem is Game game)
                Run(game);
        }

        private void lbItems_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            int idx = e.Index;
            if (idx >= 0)
                using (Graphics g = e.Graphics)
                {
                    Font f = e.Font ?? lbItems.Font;
                    Brush b = new SolidBrush(e.ForeColor);
                    Brush bgray = new SolidBrush(Color.Silver);
                    if (lbItems.Items[idx] is Game gm)
                    {
                        g.DrawString(gm.Name, f, b, 34, e.Bounds.Top + 2);
                        SizeF sz = g.MeasureString(gm.Category, f);
                        g.DrawString(gm.Category, f, bgray, e.Bounds.Right - sz.Width - 2, e.Bounds.Bottom - sz.Height - 2);
                        g.DrawImage(gm.Icon, 1, e.Bounds.Top + 1, 32, 32);
                    }
                }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Relocate();
        }
    }
}