using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mapdemo2
{
    class Edge
    {
        private Node snode;//起点
        private Node enode;//终点
        private int svalue;//权值
        internal EdgesCollection edges;//边的集合
        private object parant;
        public Edge(Node snode,Node enode)
        {
            this.snode =snode;
            this.enode = enode;
            edges = new EdgesCollection(this);
        }

        public Edge()
        {
        }

        public Node Snode
        {
            get
            {
                return snode;
            }
            set
            {
                snode = value;
            }
        }
        public Node Enode
        {
            get
            {
                return enode;
            }
            set
            {
                enode = value;
            }
        }
        public int Svalue
        {
            get
            {
                return svalue;
            }
            set
            {
                svalue = value;
            }
        }
        public virtual EdgesCollection Edges
        {
            get
            {
                return this.edges;
            }
        }
        public object Parant
        {
            get
            {
                return parant;
            }
            set
            {
                parant = value;
            }
        }
    }
}
