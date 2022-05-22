using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDosBox.i18n
{
    public abstract class Lang
    {
        #region Static
        private static Lang lang;
        public static Lang Current => lang;

        static Lang()
        {
            SetLanguage();
        }

        public static void SetLanguage()
        {
            SetLanguage(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName);
        }

        public static void SetLanguage(string isoCode)
        {
            switch (isoCode)
            {
                case "es":
                    lang = new LangEs();
                    break;
                default:
                    lang = new LangEn();
                    break;
            }
        }
        #endregion

        public abstract string labelAdd { get; }
        public abstract string labelRemove { get; }
        public abstract string labelSettings { get; }
        public abstract string labelConfRoot { get; }
        public abstract string labelConfRootTooltip { get; }
        public abstract string labelConfDosBox { get; }
        public abstract string labelConfDosBoxTooltip { get; }
    }
}
