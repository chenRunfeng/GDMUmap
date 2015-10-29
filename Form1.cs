using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Collections;

namespace mapdemo2
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public partial class MainForm : Form
    {
        //Vertex[] vertexs;
        //static int vexnumber=0;
        public static MainForm fr1;
        public MainForm()
        {
            InitializeComponent();
            fr1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\gdmcmap.html";
            Uri url = new Uri(str_url);
            //webBrowser1.Url = url;
            webBrowser1.Navigate(url);
            webBrowser1.ObjectForScripting = this;
        }
        //public  void AddVex(string name, string tag, string note, double lng, double lat)
        //{
        //    vertexs[vexnumber] = new Vertex(name, tag, note, lng, lat);
        //    vexnumber++;
        //    //comboBox2.Items.Add(pointname[t]);
        //    //comboBox1.Items.Add(b);//添加终点
        //    ////}
        //    string v = combox1select.ToString();//获取终点名
        //    textBox5.Text = " ";
        //    if (t == r1)
        //    {
        //        MessageBox.Show("各点分别为: \n");

        //        for (int i = 0; i < r1; i++)
        //            //Console.Write("V{0} ", i);

        //            MessageBox.Show("V" + i + pointname[i]);
        //        //Console.Write("  假定第一个点是配送中心");
        //        MessageBox.Show(" 假定第一个点是配送中心");
        //        //Console.WriteLine("\n\n输入各点之间的距离(无通径的用个大整数表示)\n");
        //        MessageBox.Show("\n\n输入各点之间的距离(无通径的用个大整数表示)\n");
        //    }
        //}
        //导航
        public void Navigate(string start,string end)
        {
            webBrowser1.Document.InvokeScript("CarN", new object[] { start, end });
        }
        //初始化标注工具
        private Boolean InitilMarktool()
        {
            webBrowser1.Document.InvokeScript("f");
            return true;
        }
        //添加标注点信息
        public void AddInfo(string tag,string note,string name= "我的标注")
        {
            webBrowser1.Document.InvokeScript("CreateMarker", new object[] {  tag, note,name });
        }
        //弹出标注信息窗口，js调用
        public void ShowInfo()
        {
            frmMarker fr2 = new frmMarker();
            fr2.ShowDialog();
        }

        private void btnMarker_Click(object sender, EventArgs e)
        {
            InitilMarktool();     
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            Navigate(comStart.Text, comEnd.Text);
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("openGetDistance");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("LocalSearch", new object[] { txtSearch.Text });
        }
    }
}
