using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace panelVisual.Properties
{
    public class boton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;

        public boton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;

        }
    }


}
