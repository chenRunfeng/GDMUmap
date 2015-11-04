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
        //internal NodesCollection Nodes;
        private static Graphic map=new Graphic();
        public static MainForm fr1;
        public static WebBrowser web1;
        NodesCollection NC = new NodesCollection();//窗口内临时储存点集
        //Node Snode;
        internal static Graphic Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
            }
        }


        public MainForm()
        {
            InitializeComponent();
            fr1 = this;
            web1 = this.webBrowser1;
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
        //public Node  Search(string Sname,string Stag,string Snote)
        //{

        //    foreach(Node snode in map.Node.Nodes)
        //    {
        //        if(snode.Name==Sname||snode.Tag==Stag||snode.Note==Snote)
        //        {
        //            return snode;
        //        }
        //    }
        //    return null;
        //}
         public bool NodeSearch(string Sname, string Stag="", string Snote="")
        {
            NodesCollection nc = new NodesCollection();
            //NodesCollection n = new NodesCollection();
            //n = map.Node.Nodes;
            foreach (Node snode1 in map.Node.Nodes)
            {
                nc.Add(snode1);
            }
            //nc = map.Node.Nodes;//临时储存点集
            for (int i=nc.Count-1;i>=0;i--)
            {
                Node snode = nc[i];
                if (snode.Name == Sname || snode.Tag == Stag || snode.Note == Snote)
                {
                    NC.Add(snode);
                    nc.Remove(snode);
                }
                
            }
            //string s = "";
            //foreach (Node snode in nc)
            //{
            //    if (snode.Name == Sname || snode.Tag == Stag || snode.Note == Snote)
            //    {
            //        NC.Add(snode);
            //        nc.Remove(snode);
            //    }
            //}
            return true;  
        }
       internal bool EdgeSearch(string start,string end, EdgesCollection ec, Edge e1)
        {
            for(int i=ec.Count-1;i>=0;i--)
            {
                 e1 = ec[i];
                if (e1.Snode.Name == start && e1.Enode.Name == end)
                {
                    return true;
                }
                   
            }
             return false;
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
            webBrowser1.Document.InvokeScript("ClearSearch");
            //Node SEnode = new Node();
            NodeSearch(txtSearch.Text, txtSearch.Text, txtSearch.Text);
            foreach(Node SEnode in NC)
            {
                if(SEnode!=null)
                {
                    webBrowser1.Document.InvokeScript("addMapOverlay", new object[] {SEnode.Name,SEnode.Tag,SEnode.Note,SEnode.Lng,SEnode.Lat });
                }
            }
            NC.Clear();
            //map.Node.Nodes.IndexOf(Snode.Name = txtSearch.Text);
            //string s="hah";
            //webBrowser1.Document.InvokeScript("LocalSearch", new object[] { txtSearch.Text });
        }
     
        private void btnDsave_Click(object sender, EventArgs e)
        {
            EdgesCollection EC = map.Edge.Edges;
            Edge edge = new Edge(); 
            double svalue=double.Parse(txtDistance.Text);;
            if (EdgeSearch(txtDstart.Text, txtDend.Text, EC,edge))
            {
                edge.Svalue = svalue;
            }
            else
            {
                if (NodeSearch(txtDstart.Text) && NodeSearch(txtDend.Text))
                {
                    edge = new Edge(NC[0], NC[1]);
                    edge.Svalue = svalue; 
                    EC.Add(edge);
                }
            }
        }
    }
}
