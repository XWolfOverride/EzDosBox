using EzDosBox.Properties;
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
                Game g = new Game(path, category, cfile);
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
        private string? iconFile;
        private string? imageFile;
        private string? infoFile;
        private string? info;
        private Image? icon;
        private Image? image;
        private bool imageLoaded = false;
        private string name;
        private string category;
        private string? dosBoxPath;

        private Game(string folder, string category, string cfile)
        {
            this.folder = folder;
            this.category = category;
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
                if (l[0] == '[' && l[^1] == ']')
                {
                    section = l[1..^1];
                    continue;
                }
                if (section == "EzDosBox")
                {
                    int dp = l.IndexOf('=');
                    if (dp > 0)
                    {
                        string key = l[..dp].Trim();
                        string value = l[(dp + 1)..].Trim();

                        switch (key)
                        {
                            case "name":
                                name = value;
                                break;
                            case "custom-dosbox-path":
                                dosBoxPath = value;
                                break;
                            case "icon-path":
                                iconFile = value;
                                break;
                            case "image-path":
                                imageFile = value;
                                break;
                            case "info-path":
                                infoFile = value;
                                break;
                            case "info":
                                info = value;
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
            psi.Arguments = "-conf " + configurationFile;
            psi.WorkingDirectory = folder;
            Process p = new()
            {
                StartInfo = psi
            };
            p.Start();
        }

        private string GetInfo()
        {
            if (info == null)
            {
                if (infoFile == null)
                {
                    infoFile = Path.Combine(folder, "info.md");
                    if (!File.Exists(infoFile))
                        infoFile = Path.Combine(folder, "info.txt");
                    if (!File.Exists(infoFile))
                        infoFile = null;
                }
                if (infoFile == null)
                    info = "";
                else
                    info = File.ReadAllText(infoFile);
            }
            return info;
        }

        private Image GetIcon()
        {
            if (icon == null)
            {
                if (iconFile == null)
                {
                    iconFile = Path.Combine(folder, "icon.ico");
                    if (!File.Exists(iconFile))
                        iconFile = Path.Combine(folder, "icon.png");
                    if (!File.Exists(iconFile))
                        iconFile = Path.Combine(folder, "icon.jpg");
                    if (!File.Exists(iconFile))
                        iconFile = Path.Combine(folder, "icon.bmp");
                    if (!File.Exists(iconFile))
                        iconFile = null;
                }
                if (iconFile == null)
                    icon = Resources.defaultIcon;
                else
                    icon = ReadImage(iconFile);
            }
            return icon;
        }

        private Image? GetImage()
        {
            if (!imageLoaded)
            {
                imageLoaded = true;
                if (imageFile == null)
                {
                    imageFile = Path.Combine(folder, "image.png");
                    if (!File.Exists(imageFile))
                        imageFile = Path.Combine(folder, "image.jpg");
                    if (!File.Exists(imageFile))
                        imageFile = Path.Combine(folder, "image.bmp");
                    if (!File.Exists(imageFile))
                        imageFile = null;
                }
                if (imageFile == null)
                    image = null;
                else
                    image = ReadImage(imageFile);
            }
            return image;
        }

        private static Image ReadImage(string path)
        {
            try
            {
                return Image.FromFile(path);
            }
            catch
            {
                try
                {
                    Icon icn = new Icon(path);
                    return icn.ToBitmap();
                }
                catch
                {
                    return Resources.imgError;
                }
            }
        }

        public string Name => name;
        public string DosBoxPath => dosBoxPath ?? Settings.DosBoxPath;
        public string Category => category;
        public string Info => GetInfo();
        public Image Icon => GetIcon();
        public Image? Image => GetImage();

        public override string ToString()
        {
            return name;
        }
    }
}
