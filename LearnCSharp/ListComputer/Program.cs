using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListComputer
{
    public class ObjEquality : IEqualityComparer<Obj>
    {
        public bool Equals(Obj x, Obj y)
        {
            return x.guid == y.guid;
        }

        public int GetHashCode(Obj obj)
        {
            return (obj == null) ? 0 : obj.guid;
        }
    }

     public class Obj
    {
        public Obj(int id)
        {
            guid = id;
        }
        public int guid;
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Obj> from = new List<Obj>();
            from.Add(new Obj(0)); from.Add(new Obj(1)); from.Add(new Obj(2));

            List<Obj> to = new List<Obj>();
            to.Add(new Obj(0)); to.Add(new Obj(1)); to.Add(new Obj(3));

            var inter = from.Intersect(to, new ObjEquality()).ToList();
            var except = from.Except(to, new ObjEquality()).ToList();
            var union = from.Union(to, new ObjEquality()).ToList();
        }
    }
}
