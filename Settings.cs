using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EzDosBox
{
    internal class Settings
    {
        #region Management
        private const string FILENAME = "EzDosBox.conf";
        private static readonly string basePath;
        private static readonly string confPath;

        static Settings()
        {
            basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "";
            confPath = EzFile(FILENAME);
            Load();
        }

        public static void Load()
        {
            Reset();
            // Read conf file
            string[] conf;
            try
            {
                conf = File.ReadAllLines(confPath);
            }
            catch
            {
                return;
            }

            // Prelocate configuration options
            Dictionary<string, FieldInfo> configurable = new Dictionary<string, FieldInfo>();
            FieldInfo[] fis = typeof(Settings).GetFields();
            foreach (FieldInfo fi in fis)
            {
                ConfAttribute? ca = fi.GetCustomAttribute(typeof(ConfAttribute)) as ConfAttribute;
                if (ca != null)
                    configurable[ca.Name] = fi;
            }

            //Process conf
            foreach (string cl in conf)
            {
                string l = cl.Trim();
                if (l.Length == 0 || l.StartsWith("#") || l.StartsWith("//"))
                    continue;
                int dp = l.IndexOf("=");
                if (dp < 0)
                    continue;
                string param = l.Substring(0, dp).Trim();
                string value = l.Substring(dp + 1).Trim();
                if (configurable.TryGetValue(param, out FieldInfo? fi) && fi!=null)
                    fi.SetValue(null, value);
            }

        }

        public static void Save()
        {
            // Write new configuration file
            List<string> lines = new List<string>();
            lines.Add("# EzDosBox 0.1 (C) XWolfOverride 2022 under MIT license");
            lines.Add("# Configuration file");

            // Fill configuration
            FieldInfo[] fis = typeof(Settings).GetFields();
            foreach (FieldInfo fi in fis)
            {
                ConfAttribute? ca = fi.GetCustomAttribute(typeof(ConfAttribute)) as ConfAttribute;
                string value = (fi.GetValue(null) as string)??"";
                if (ca != null)
                {
                    lines.Add("");
                    if (ca.Info != null)
                        lines.Add("# "+ca.Info);
                    lines.Add(ca.Name+"="+value);
                }
            }
            try
            {
                File.WriteAllLines(confPath,lines.ToArray());
            }
            catch
            {
                return;
            }

        }

        public static void Reset()
        {
            RootFolder = basePath;
            DosBoxPath = Path.Combine(basePath, "DosBox.exe");
        }

        public static string EzFile(string name)
        {
            return Path.Combine(basePath, name);
        }
        #endregion

        // Settings
        [Conf("RootFolder", Info = "Base path for DOS applications")]
        public static string RootFolder = "";

        [Conf("DosBoxPath", Info = "DosBox.exe path")]
        public static string DosBoxPath = "";
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class ConfAttribute : Attribute
    {
        private string name;
        public string? Info;

        public ConfAttribute(string name)
        {
            this.name = name;
        }

        public string Name => name;
    }
}
