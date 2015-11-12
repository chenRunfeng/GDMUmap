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
using System.IO;

namespace mapdemo2
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public partial class MainForm : Form
    {
        //Vertex[] vertexs;
        //static int vexnumber=0;
        //internal NodesCollection Nodes;
        private static Graphic map = new Graphic();
        public static MainForm fr1;
        public static WebBrowser web1;
        NodesCollection NC = new NodesCollection();//窗口内临时储存点集
        string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "GDMUmap";
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
            web1 = this.WebGdmumap;
        }
        //初始化地图
        private void Form1_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\gdmcmap.html";
            Uri url = new Uri(str_url);
            //webBrowser1.Url = url;
            WebGdmumap.Navigate(url);
            WebGdmumap.ObjectForScripting = this;
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
        //标注点导航
        internal void Navigates(Node start,Node end)
        {
            WebGdmumap.Document.InvokeScript("CarN", new object[] { start.Lng,start.Lat,end.Lng,end.Lat });
            WebGdmumap.Document.InvokeScript("WalkerN", new object[] { start.Lng, start.Lat, end.Lng, end.Lat });
        }
        //初始化标注工具
        private Boolean InitilMarktool()
        {
            WebGdmumap.Document.InvokeScript("f");
            return true;
        }
        //添加标注点信息
        public void AddInfo(string tag,string note,string name= "我的标注")
        {
            WebGdmumap.Document.InvokeScript("CreateMarker", new object[] {  tag, note,name });
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
         public void NodeSearch(string Sname, string Stag="", string Snote="")
        {
            //bool noNode=false;//等于false表示已有node
                NodesCollection nc = new NodesCollection();
                //NodesCollection n = new NodesCollection();
                //n = map.Node.Nodes;
                foreach (Node snode1 in map.Node.Nodes)
                {
                    nc.Add(snode1);
                }
                //nc = map.Node.Nodes;//临时储存点集
                for (int i = nc.Count - 1; i >= 0; i--)
                {
                    Node snode = nc[i];
                    if (snode.Name == Sname || snode.Tag == Stag || snode.Note == Snote)
                    {
                        NC.Add(snode);
                        nc.Remove(snode);
                    }

                }
            //if (NC[0] != null)
            //    return true;
            //else return false;
                   

            //string s = "";
            //foreach (Node snode in nc)
            //{
            //    if (snode.Name == Sname || snode.Tag == Stag || snode.Note == Snote)
            //    {
            //        NC.Add(snode);
            //        nc.Remove(snode);
            //    }
            //}  
        }
        internal static Node SearchNode(string Sname)
        {
            NodesCollection nc = new NodesCollection();
            foreach (Node snode1 in map.Node.Nodes)
            {
                nc.Add(snode1);
            }
            //nc = map.Node.Nodes;//临时储存点集
            for (int i = nc.Count - 1; i >= 0; i--)
            {
                Node snode = nc[i];
                if (snode.Name == Sname )
                {
                    return snode;
                }

            }
            return null;
        }
       internal bool EdgeSearch(string start,string end, EdgesCollection ec,ref Edge e1)
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
        public void DeleteNode(string name)
        {
            if(SearchNode(name)!=null)
            {
                map.Node.Nodes.Remove(SearchNode(name));
            }
        }
        //int[] print;//定义输入点到点距离大小的数组
        //int k = 0;//用于自增后读出print里的数据
        internal void exchange(EdgesCollection edge1)
        {
            int r = map.Node.Nodes.Count;//输入点数R
            //int k = 0;//用于自增后读出print里的数据
            double[] a=new double[(r ) * (r )];
            Node n1 = new Node();
            Node n2 = new Node();
            Edge edge2 = new Edge();
            //Edge edge3 = new Edge();
            for (int i = 0; i < r; i++)
            {
               n1 = map.Node.Nodes[i];
                for (int j = i + 1; j < r; j++)
                {
                   n2= map.Node.Nodes[j];
                    if(EdgeSearch(n1.Name, n2.Name, edge1, ref edge2))
                    {
                        a[i * r + j] = edge1[map.Edge.Edges.IndexOf(edge2)].Svalue;
                    }
                    //MessageBox.Show(edge1[k].Snode.Name + "到" + edge1[k].Enode.Name + "的距离是：" + edge1[k].Svalue);
                    //a[i * r + j] = edge1[map.Edge.Edges.IndexOf(edge2)].Svalue;
                    //if (k < r * (r - 1) / 2)
                    //{
                    //    k++;
                    //}
                }
            }
            //----完善距离矩阵(距离矩阵其实可以是个上三角矩阵，
            //----但为了处理方便，还是将其完整成一个对称阵)-----------
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (i == j)
                    {
                        a[i * r + j] = 0;
                    }
                    a[j * r + i] = a[i * r + j];
                }
                if (i == r - 1)
                {
                    //int index=map.Node.Nodes.IndexOf( SearchNode(comStart.Text));
                    Dijksta m = new Dijksta(r,a);
                    string outs="";
                    m.Find_way();
                    m.Display(ref outs, comEnd.Text, map.Node.Nodes);
                    txtOutroute.Text = outs;

                }
            }
        }
        private void btnMarker_Click(object sender, EventArgs e)
        {
            InitilMarktool();     
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            try
            {
                Navigates(SearchNode(comStart.Text), SearchNode(comEnd.Text));
                //EdgesCollection ed = new EdgesCollection();
                //Edge edge = new Edge();
                //foreach (Edge edge1 in map.Edge.Edges)
                //{
                //    ed.Add(edge1);
                //    //string s = "";
                //}
                //if (EdgeSearch(comStart.Text, comEnd.Text, ed, ref edge))
                //{
                //    //Edge temp = edge;
                //    int i = ed.IndexOf(edge);
                //    Edge e1 = new Edge(ed[0].Snode, ed[0].Enode, ed[0].Svalue);
                //    Edge e2 = new Edge(ed[i].Snode, ed[i].Enode, ed[i].Svalue);
                //    //ed.Replace(ed.IndexOf(edge),)
                //    ed.Replace(0, ed[0], e2);
                //    ed.Replace(i, ed[i], e1);
                //    //Edge e2 = ed[0];
                //    //ed.Replace(0, ed[0], edge);
                //}
                exchange(map.Edge.Edges);
             }
            catch
            {
                //导航，标注点和百度地图原有的地点实现导航
                if (SearchNode(comStart.Text) != null && SearchNode(comEnd.Text) != null)
                    Navigates(SearchNode(comStart.Text), SearchNode(comEnd.Text));
                else if (SearchNode(comStart.Text) != null && SearchNode(comEnd.Text) == null)
                {
                    Node n = SearchNode(comStart.Text);
                    WebGdmumap.Document.InvokeScript("CarN2", new object[] { n.Lng, n.Lat, comEnd.Text });
                    WebGdmumap.Document.InvokeScript("WalkerN2", new object[] { n.Lng, n.Lat, comEnd.Text });
                }
                else if (SearchNode(comStart.Text) == null && SearchNode(comEnd.Text) != null)
                {
                    Node n = SearchNode(comEnd.Text);
                    WebGdmumap.Document.InvokeScript("CarN3", new object[] { comStart.Text, n.Lng, n.Lat });
                    WebGdmumap.Document.InvokeScript("WalkerN3", new object[] { comStart.Text, n.Lng, n.Lat });
                }
                else
                {
                    WebGdmumap.Document.InvokeScript("CarN1", new object[] { comStart.Text, comEnd.Text });
                    WebGdmumap.Document.InvokeScript("WalkerN1", new object[] { comStart.Text, comEnd.Text });
                }
            }
            comEnd.Items.Add(comEnd.Text);
            comStart.Items.Add(comStart.Text);
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            WebGdmumap.Document.InvokeScript("openGetDistance");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //在点集中没有找到就从百度地图云中找
            try
            {
                WebGdmumap.Document.InvokeScript("ClearSearch");
                //Node SEnode = new Node();
                //if (NodeSearch(txtSearch.Text, txtSearch.Text, txtSearch.Text))
                //{
                NodeSearch(txtSearch.Text, txtSearch.Text, txtSearch.Text);
                foreach (Node SEnode in NC)
                {
                    if (SEnode != null)
                    {
                        WebGdmumap.Document.InvokeScript("addMapOverlay", new object[] { SEnode.Name, SEnode.Tag, SEnode.Note, SEnode.Lng, SEnode.Lat });
                    }
                }
                if(NC.Count==0)
                { WebGdmumap.Document.InvokeScript("LocalSearch", new object[] { txtSearch.Text }); }
                NC.Clear();
            }
            //}
            //else
            //{
            catch
            {
                //WebGdmumap.Document.InvokeScript("ClearSearch");
                //foreach (Node SEnode in NC)
                //{
                //    if (SEnode != null)
                //    {
                //        WebGdmumap.Document.InvokeScript("addMapOverlay", new object[] { SEnode.Name, SEnode.Tag, SEnode.Note, SEnode.Lng, SEnode.Lat });
                //    }
                //}
                //NC.Clear();
                try
                {
                    WebGdmumap.Document.InvokeScript("ClearSearch");
                    WebGdmumap.Document.InvokeScript("LocalSearch", new object[] { txtSearch.Text });
                }
                catch
                {
                    MessageBox.Show("不存在这个地点，请确认地点名称是否正确");
                }
                
            }
            //}
            //map.Node.Nodes.IndexOf(Snode.Name = txtSearch.Text);
            //string s="hah";
            //webBrowser1.Document.InvokeScript("LocalSearch", new object[] { txtSearch.Text });
        }

        private void btnDsave_Click(object sender, EventArgs e)
        {
            EdgesCollection EC = map.Edge.Edges;
            Edge edge = new Edge(); 
            double svalue=double.Parse(txtDistance.Text);;
            if (EdgeSearch(txtDstart.Text, txtDend.Text, EC,ref edge))
            {
                edge.Svalue = svalue;
                MessageBox.Show("修改距离成功！");
            }
            else
            {
                if (SearchNode(txtDstart.Text)!=null && SearchNode(txtDend.Text)!=null)
                {
                    edge = new Edge(SearchNode(txtDstart.Text), SearchNode(txtDend.Text));
                    edge.Svalue = svalue; 
                    EC.Add(edge);
                    MessageBox.Show("添加距离成功！");
                }
            }
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnDreset_Click(object sender, EventArgs e)
        {
            txtDend.Text = "";
            txtDistance.Text = "";
            txtDstart.Text = "";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(map.Node.Nodes.Count != 0)
            {
                DialogResult d;
                d = MessageBox.Show("是否保存已经添加的标注点？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    if (!Directory.Exists(Path))
                    {
                        Directory.CreateDirectory(Path);
                    }
                    if (map.Node.Nodes.Count != 0)
                    {
                        NodesCollection nc = map.Node.Nodes;
                        StreamWriter sw = new StreamWriter(Path + "\\" + "Nodesinformation.txt", false);  /*File.AppendText(path + "\\" + "Nodesinformation.txt");*/
                        for (int i = 0; i < nc.Count; i++)
                        {
                            sw.Write(i.ToString() + "\r\n" + nc[i].Name + "\r\n" + nc[i].Tag + "\r\n" + nc[i].Note + "\r\n" + nc[i].Lng.ToString() + "\r\n" + nc[i].Lat.ToString() + "\r\n");
                        }
                        sw.Close();
                        MessageBox.Show("标注点已保存");
                    }
                    if (map.Edge.Edges.Count != 0)
                    {
                        EdgesCollection edge = map.Edge.Edges;
                        StreamWriter ed = new StreamWriter(Path + "\\" + "Edgesinformation.txt", false);
                        for (int i = 0; i < edge.Count; i++)
                        {
                            ed.Write(i.ToString() + "\r\n" + edge[i].Snode.Name + "\r\n" + edge[i].Enode.Name + "\r\n" + edge[i].Svalue.ToString() + "\r\n");

                        }
                        ed.Close();
                        MessageBox.Show("距离已保存");
                    }
                    //sw.WriteLine(nc[i].Name + "\r\n" + nc[i].Tag + "\r\n" + nc[i].Note + "\r\n" + nc[i].Lng.ToString + "\r\n" + nc[i].Lat.ToString + "\r\n");
                    //sw.WriteLine("标题:" + txtTitle.Text + "\r\n" + "标签:" + comTag.Text + "\r\n" + "备注：" + txtNote.Text + "\r\n");
                    //sw.Close();

                }
            }
        }

        private void WebGdmumap_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            map.CreateGraph(Path + "\\" + "Nodesinformation.txt", Path + "\\" + "Edgesinformation.txt");
        }
    }
}
