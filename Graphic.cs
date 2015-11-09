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
        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
        public void CreateGraph(string filepath)//n为顶点数,e为边数
        {
            for(int i=0;)
        }
    }
}
