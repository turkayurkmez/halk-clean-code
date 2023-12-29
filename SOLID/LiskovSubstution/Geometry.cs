using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    internal class Geometry
    {
        public IArea GetRectangle(int unit1, int? unit2 = null)
        {
            //bir şeyler bir şeyler....
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }

            return new Square { Edge = unit1 };
        }
    }

    public interface IArea
    {
        int GetArea();
    }

    public class Rectangle : IArea
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea() => Width * Height;
    }

    public class Square : IArea //: Rectangle
    {

        public int Edge { get; set; }
        //public override int Width
        //{
        //    get => base.Width;
        //    set
        //    {
        //        base.Width = value;
        //        base.Height = value;
        //    }
        //}

        //public override int Height { get => base.Width; set { base.Width = value; base.Height = value; } }

        public int GetArea() => Edge * Edge;
    }
}
