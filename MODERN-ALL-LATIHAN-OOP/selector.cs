using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODERN_ALL_LATIHAN_OOP.Forms;

namespace MODERN_ALL_LATIHAN_OOP
{
    public class selector
    {
        public static Dictionary<string, Action> formSelector = new Dictionary<string, Action>();

        public static void Initialize()
        {
            formSelector.Add("FormOvo", () => new FormOvo().Activate());
        }
    }
}
