using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructClass
{
    class KeyClass
    {
        public KeyClass(int x)
        {
            this.x = x;
        }

        public int x;
    }

    class CustomClass
    {
        public CustomClass(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float x, y, z;
    }

    struct Vector3 : IEquatable<Vector3>
    {
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override bool Equals(object other)
        {
            if (!(other is Vector3)) return false;

            return Equals((Vector3)other);
        }

        public bool Equals(Vector3 obj)
        {
            return x == obj.x && y == obj.y && z.Equals(obj.z);
        }

        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return !lhs.Equals(rhs);
        }

        public float x, y, z;
    }


    class Vector3Comparer : IEqualityComparer<Vector3>
    {
        public bool Equals(Vector3 x, Vector3 y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(Vector3 obj)
        {
            int hash = obj.GetHashCode();
            return hash;
        }
    }
}

//public static readonly IEqualityComparer<Vector3> Instance = new Vector3Comparer();
