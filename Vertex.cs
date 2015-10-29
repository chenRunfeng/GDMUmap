using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mapdemo2
{
    class Vertex
    {

        public Vertex(string name, string tag, string note, double lng, double lat)
        {
            Name = name;
            Tag = tag;
            Note = note;
            Lng = lng;
            Lat = lat;
        }
        public string Tag;
        public string Name;
        public string Note;
        public double Lng;//经纬
        public double Lat;
    }




}
