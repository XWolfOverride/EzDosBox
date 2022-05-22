using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDosBox
{
    internal class Game
    {
        #region Static Management

        private static List<Game> games = new List<Game>();

        static Game()
        {
            Scan(Settings.RootFolder, "", true);
        }

        private static void Scan(string path, string category, bool root)
        {
            string name = Path.GetFileName(path);
            string cfile = Path.Combine(path, name + ".conf");
            if (!root && File.Exists(cfile))
            {
                //Game
                Game g = new Game(path,cfile);
                games.Add(g);
            }
            else
            {
                //Category
                if (root)
                    root = false;
                else
                {
                    if (category.Length > 0)
                        category += "/";
                    category += name;
                }
                foreach (string s in Directory.GetDirectories(path))
                    Scan(s, category, false);
            }
        }

        public static void Clear()
        {
            games.Clear();
        }

        public static Game[] List => games.ToArray();

        #endregion

        private string folder;
        private string configurationFile;
        private string iconFile;
        private string imageFile;
        private string info;
        private string name;
        private string? dosBoxPath;

        private Game(string folder,string cfile)
        {
            this.folder = folder;
            configurationFile = cfile;
            name = Path.GetFileName(folder);
            Read();
        }

        private void Read()
        {
            string[] gconf = File.ReadAllLines(configurationFile);
            string section = "";
            foreach (string gl in gconf)
            {
                string l = gl.Trim();
                if (l.Length == 0)
                    continue;
                if (l[0] == '[' && l[l.Length - 1] == ']')
                {
                    section = l.Substring(1, l.Length - 2);
                    continue;
                }
                if (section == "EzDosBox")
                {
                    int dp = l.IndexOf('=');
                    if (dp > 0)
                    {
                        string key = l.Substring(0, dp).Trim();
                        string value = l.Substring(dp + 1).Trim();

                        switch (key)
                        {
                            case "name":
                                name = value;
                                break;
                            case "custom-dosbox-path":
                                dosBoxPath = value;
                                break;
                        }
                    }
                }
            }
        }

        public void Run()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = DosBoxPath;
            psi.Arguments = "-conf "+configurationFile;
            psi.WorkingDirectory = folder;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        public string Name => name;
        public string DosBoxPath => dosBoxPath ?? Settings.DosBoxPath;

        public override string ToString()
        {
            return name;
        }
    }
}
