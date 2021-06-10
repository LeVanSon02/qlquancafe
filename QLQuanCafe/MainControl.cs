using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLQuanCafe
{
    class MainControl
    {
        public static void ShowControl(Control control, Control content)
        {
            content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            content.Controls.Add(control);
        }
    }
}
