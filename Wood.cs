using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarFinalApp.Model
{
    internal enum Wood
    
        {
            [Description("Indian Rosewood")] Indian_Rosewood,
            [Description("Brazilian Rosewood")] Brazilian_Rosewood,
            Mahogany,
            Maple,
            Cocobolo,
            Cedar,
            Adirondack,
            Alder,
            Sitka
        }
}
