using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOPAssignment.First_Project
{
    internal class Point3D : IComparable<Point3D> , ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(int x, int y) : this(x, y, 0) { }

        public Point3D() : this(0, 0, 0) { }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
      

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public int CompareTo(Point3D? compare)
        {
            if (compare == null) return 1;

            if (X != compare?.X)
            {
                return X.CompareTo(compare?.X);
            }
            if (Y != compare?.Y)
            {
                return Y.CompareTo(compare?.Y);
            }
            return Z.CompareTo(compare?.Z);
        }
    }
}
