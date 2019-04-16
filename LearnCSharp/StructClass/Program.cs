using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructClass
{

    class Program
    {
        static void Main(string[] args)
        {
            //equ
            Vector3 a = new Vector3(0,0,0);
            Vector3 b = new Vector3(1,0,0);
            bool bE = a.Equals(b);

            //bE = a == b;

            //struct key
            Dictionary<Vector3, CustomClass> dic = new Dictionary<Vector3, CustomClass>(new Vector3Comparer());
            Vector3 key1 = new Vector3(0,0,0);
            CustomClass value1 = new CustomClass(0,0,0);
            dic.Add(key1, value1);
            key1.x = 1;
            dic.Add(key1, value1);

            Dictionary<Vector3, CustomClass> dicCopy = new Dictionary<Vector3, CustomClass>(new Vector3Comparer());
            key1.x = 0;
            dicCopy.Add(key1, value1);
            key1.x = 3;
            dicCopy.Add(key1, value1);
          

            Dictionary<Vector3, CustomClass> unionDic = new Dictionary<Vector3, CustomClass>(new Vector3Comparer());
            var unionList = dicCopy.Union(dic);

            foreach (var pair in unionList)
            {
                var k1 = pair.Key;
                var v1 = pair.Value;
                unionDic.Add(k1, v1);
            }

            Dictionary<Vector3, CustomClass> interDic = new Dictionary<Vector3, CustomClass>(new Vector3Comparer());
            var interList = dicCopy.Intersect(dic);
            foreach (var pair in interList)
            {
                var k1 = pair.Key;
                var v1 = pair.Value;
                interDic.Add(k1, v1);
            }

            bool aaa = false;

            bool bEqual = interDic == unionDic;



            //class key
//            Dictionary<KeyClass, CustomClass> dic2 = new Dictionary<KeyClass, CustomClass>();
//
//            KeyClass k = new KeyClass(0);
//            dic2.Add(k, value1);
//
//            value1.x = 1;
//            k.x = 1;
//            dic2.Add(k, value1);

        }
    }
}
