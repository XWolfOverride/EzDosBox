using EzDosBox.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDosBox
{
    public partial class FSettings : Form
    {
        private FSettings()
        {
            InitializeComponent();
            // i18n
            Text = Lang.Current.labelSettings;
            lbRoot.Text = Lang.Current.labelConfRoot;
            lbDosBox.Text = Lang.Current.labelConfDosBox;
            toolTip.SetToolTip(tbRoot, Lang.Current.labelConfRootTooltip);
            toolTip.SetToolTip(tbDosBox, Lang.Current.labelConfDosBoxTooltip);
            // conf
            tbRoot.Text = Settings.RootFolder;
            tbDosBox.Text = Settings.DosBoxPath;

        }

        public static void Execute()
        {
            using (FSettings f = new FSettings())
            {
                f.ShowDialog();
                Settings.RootFolder = f.tbRoot.Text;
                Settings.DosBoxPath = f.tbDosBox.Text;
                Settings.Save();
            }
        }

        private void btRootChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            try
            {
                fbd.InitialDirectory = tbRoot.Text;
            }
            catch { }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbRoot.Text = fbd.SelectedPath;
            }
        }

        private void btDosBoxChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "DosBox exe|*.exe";
            ofd.Title = Lang.Current.labelConfDosBox;
            try
            {
                ofd.FileName = tbDosBox.Text;
            }
            catch { }
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbDosBox.Text = ofd.FileName;
            }
        }
    }
}
