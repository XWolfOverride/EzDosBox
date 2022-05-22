using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDosBox.i18n
{
    internal class LangEs:Lang
    {
        public override string labelAdd => "Añadir";

        public override string labelRemove => "Borrar";

        public override string labelSettings => "Configuración";

        public override string labelConfRoot => "Directorio Inicial";

        public override string labelConfRootTooltip => "Directorio que contiene las configuraciones de juegos o aplicaciones Dos";

        public override string labelConfDosBox => "Ruta DosBox.exe";

        public override string labelConfDosBoxTooltip => "Ruta al programa DosBox";
    }
}
