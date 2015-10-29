using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Collections;

namespace mapdemo2
{
    class Common
    {
        public void Addinfo()
        {
            frmMarker fr2 = new frmMarker();
            fr2.ShowDialog();
        }
    }
}
