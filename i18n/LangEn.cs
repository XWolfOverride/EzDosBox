using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDosBox.i18n
{
    internal class LangEn : Lang
    {
        public override string labelAdd => "Add";

        public override string labelRemove => "Remove";

        public override string labelSettings => "Settings";

        public override string labelConfRoot => "Root Applications Folder";

        public override string labelConfRootTooltip => "Path of the root folder containing all DOS Games or application configurations";

        public override string labelConfDosBox => "DosBox.exe path";

        public override string labelConfDosBoxTooltip => "Path of the executable DosBox program";
    }
}
