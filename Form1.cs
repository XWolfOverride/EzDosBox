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

        private void ShowDetails(Game g)
        {

        }

        private void Run(Game g)
        {
            g.Run();
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            FSettings.Execute();
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game? game = lbItems.SelectedItem as Game;
            if (game != null)
                ShowDetails(game);
        }

        private void lbItems_DoubleClick(object sender, EventArgs e)
        {
            Game? game = lbItems.SelectedItem as Game;
            if (game != null)
                Run(game);
        }
    }
}