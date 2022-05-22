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

        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            FSettings.Execute();
        }
    }
}