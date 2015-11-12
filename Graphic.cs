using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace mapdemo2
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    class Graphic
    {
        private Node node;//点
        private Edge edge;//边
        public GraphKind kind;
        public Graphic()
        {
            node = new Node();
            edge = new Edge();
        }
        public enum GraphKind
        {
            DG,//有向图
            DN,//有向网
            AG,//无向图
            AN//无向网
        }
        public GraphKind Kind
        {
            get
            {
                return this.kind;
            }
            set
            {
                this.kind = value;
            }
        }
        public Node Node
        {
            get
            {
                return this.node;
            }
            set
            {
                this.node = value;
            }
        }
        public Edge Edge
        {
            get
            {
                return this.edge;
            }
            set
            {
                this.edge = value;
            }
        }
        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
        public void CreateGraph(string Nodesfilepath,string Edgesfilepath)//n为顶点数,e为边数
        {
            if(File.Exists(Nodesfilepath))
            {
                string[] nodesinformation = File.ReadAllLines(Nodesfilepath);
                int i;
                for ( i=0; i < nodesinformation.Length; i += 6)
                {
                        int j = i+1;
                        string name = nodesinformation[j++];
                        string tag = nodesinformation[j++];
                        string note = nodesinformation[j++];
                        double lng = double.Parse(nodesinformation[j++]);
                        double lat = double.Parse(nodesinformation[j++]);
                    Node node0 = new Node(name, tag, note, lng, lat);
                    node.Nodes.Add(node0);
                    MainForm.web1.Document.InvokeScript("addMapOverlay1", new object[] { node0.Name, node0.Tag, node0.Note, node0.Lng, node0.Lat });
                }
            }
            if(File.Exists(Edgesfilepath))
            {
                try
                {
                    string[] edgesinformation = File.ReadAllLines(Edgesfilepath);
                    int i;
                    for (i = 0; i < edgesinformation.Length; i += 4)
                    {

                        int j = i + 1;
                        string SnodeName = edgesinformation[j++];
                        string EnodeName = edgesinformation[j++];
                        double edgeSvalue = double.Parse(edgesinformation[j++]);
                        Edge edge0 = new Edge();
                       if (MainForm.SearchNode(SnodeName) != null &&MainForm.SearchNode(EnodeName) != null)
                        {
                            edge0 = new Edge(MainForm.SearchNode(SnodeName), MainForm.SearchNode(EnodeName), edgeSvalue);
                            //edge.Svalue = ;
                            edge.Edges.Add(edge0);
                        }
                    }
                }
                catch { };
            }
            
            //for(int i=0;)
            //for (int i = 0;)
            //string s = "";
        }
    }
}
