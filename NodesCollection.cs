using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mapdemo2
{
    class NodesCollection : CollectionBase
    {
        private object self;
        public NodesCollection()
        {
        }
        public NodesCollection(object parent)
        {
            this.self = parent;
        }
        public Node this[int index]
        {
            get
            {
                return (Node)base.List[index];
            }
        }
        public object Parent
        {
            get
            {
                return this.self;
            }
            set
            {
                this.self = value;
            }
        }
        private void InitNodeCollection(Node node1)
        {
            node1.Parant = this.Parent;
        }
        protected override void OnSet(int index, object oldValue, object newValue)
        {
            this.InitNodeCollection((Node)newValue);
            base.OnSet(index, oldValue, newValue);
        }
        public void Add(Node item)
        {
            base.List.Add(item);
        }
        public void AddAt(int index, Node item)
        {
            base.List.Insert(index, item);
        }
        public bool Contains(Node item)
        {
            return base.List.Contains(item);
        }
        public int IndexOf(Node item)
        {
            return base.List.IndexOf(item);
        }
        public void Remove(Node item)
        {
            base.List.Remove(item);
        }
        //public NodesCollection Clone()
        //{
        //    return (NodesCollection)this.MemberwiseClone();
        //}
        //public NodesCollection Search(string Sname, string Stag, string Snote)
        //{
        //    NodesCollection NC = new NodesCollection();
        //    foreach (Node snode in MainForm.Map.Node.Nodes)
        //    {
        //        if (snode.Name == Sname || snode.Tag == Stag || snode.Note == Snote)
        //        {
        //            NC.Add(snode);
        //        }
        //    }
        //    return NC;
        //}
    }
}
