using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mapdemo2
{
    class Node
    {
        //private int num;//编号
        private string name;//数据
        private string tag;
        private string note;
        private double lng;//经度
        private double lat;//纬度
        internal NodesCollection nodes;//节点的集合
        private object parant;
        //public string Tag;
        ////public string Name;
        //public string Note;
        //public double Lng;//经纬
        //public double Lat;
        public Node(string name="我的标注", string tag="", string note="", double lng=0, double lat=0)
        {
            this.name = name;
            this.tag = tag;
            this.note = note;
            this.lng = lng;
            this.lat = lat;
            nodes = new NodesCollection(this);
        }

        public Node()
        {
            nodes = new NodesCollection(this);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Tag
        {
            get
            {
                return tag;
            }
            set
            {
                tag = value;
            }
        }
        public string Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
            }
        }
        public double Lng
        {
            get
            {
                return lng;
            }
            set
            {
                lng = value;
            }
        }
        public double Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
            }
        }
        //public int Num
        //{
        //    get
        //    {
        //        return num;
        //    }
        //    set
        //    {
        //        num = value;
        //    }
        //}
        public virtual NodesCollection Nodes
        {
            get
            {
                return this.nodes;
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
