using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mapdemo2
{
    class EdgesCollection : CollectionBase
    {
        private object self;
        public EdgesCollection()
        {
        }
        public EdgesCollection(object parent)
        {
            this.self = parent;
        }
        public Edge this[int index]
        {
            get
            {
                return (Edge)base.List[index];
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
        private void InitNodeCollection(Edge node1)
        {
            node1.Parant = this.Parent;
        }
        protected override void OnSet(int index, object oldValue, object newValue)
        {
            this.InitNodeCollection((Edge)newValue);
            base.OnSet(index, oldValue, newValue);
        }
        public void Add(Edge item)
        {
            base.List.Add(item);
        }
        public void AddAt(int index, Edge item)
        {
            base.List.Insert(index, item);
        }
        public bool Contains(Edge item)
        {
            return base.List.Contains(item);
        }
        public int IndexOf(Edge item)
        {
            return base.List.IndexOf(item);
        }
        public void Remove(Edge item)
        {
            base.List.Remove(item);
        }
    }
}
