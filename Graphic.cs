using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mapdemo2
{
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
        public void CreateGraph(int n, int e)//n为顶点数,e为边数
        {
            int i, j, k, w;
            object b, t;
            Graphic Graphic1 = new Graphic();
            Console.Write("\n顶点数n和边数e");
            for (i = 0; i < n; i++)
            {
                Console.Write("\t第" + i + "个顶点的信息：");
                Node node1 = new Node();
                //node1.Num = i;
                node1.Name = i.ToString();
                Graphic1.Node.Nodes.Add(node1);
            }
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    Edge edge1 = new Edge();
                    edge1.Snode = Graphic1.Node.Nodes[i];
                    edge1.Enode = Graphic1.Node.Nodes[j];
                    edge1.Svalue = 0;
                    Graphic1.Edge.Edges.Add(edge1);
                }
            for (k = 0; k < e; k++)
            {
                Console.Write("第" + k + "条边=>\n\t起点:");
                b = Console.ReadLine();
                Console.Write("终点");
                t = Console.ReadLine();
                Console.Write("权值");
                w = int.Parse(Console.ReadLine());
                i = 0;
                while (i < n && Graphic1.Node.Nodes[i].Name != b.ToString())
                    i++;
                if (i > n)
                {
                    Console.Write("输入起点不存在");
                    Console.Error.Close();
                }
                j = 0;
                while (j < n && Graphic1.Node.Nodes[j].Name != t.ToString())
                    j++;
                if (j > n)
                {
                    Console.Write("输入起点不存在");
                    Console.Error.Close();
                }
                Graphic1.Edge.Edges[k].Svalue = w;
            }
        }
    }
}
