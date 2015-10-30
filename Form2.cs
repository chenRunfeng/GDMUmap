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
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class frmMarker : Form
    {
        Vertex[] vertexs=new Vertex[100];
        static int vexnumber=0;
        public frmMarker()
        {
            InitializeComponent();
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.fr1.AddInfo( comTag.Text, txtNote.Text, txtTitle.Text);
            double lng, lat;
            lng = double.Parse(MainForm.web1.Document.GetElementById("lng").InnerText);
            lat = double.Parse(MainForm.web1.Document.GetElementById("lat").InnerText);
            vertexs[vexnumber] = new Vertex(txtTitle.Text, comTag.Text, txtNote.Text, lng, lat);
            vexnumber++;
        }
    }
}
