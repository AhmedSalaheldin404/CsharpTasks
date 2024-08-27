namespace SHAPE
{
    internal class Program
    {
        abstract class Shape
        {
            protected int dim1, dim2;
            public Shape() { dim1 = dim2 = 0; }
            public Shape(int width) { dim1 = dim2 = width; }
            public Shape(int width, int length)
            {
                dim1 = width;
                dim2 = length;
            }
            public int getdim1() { return dim1; }
            public void setdim1(int width) { dim1 = width; }
            public int setdim2() { return dim2; }
            public void setdim2(int length) { dim2 = length; }
            public abstract double area();
        }
        class circle : Shape
        {
            public circle() { }
            public circle(int r) : base(r) { }
            public override double area() { return (3.14 * dim1 * dim2); }

        }

        class Rect : Shape
        {
            public Rect() { }
            public Rect(int w, int l) : base(w, l) { }
            public override double area() { return (1.0 * dim1 * dim2); }

        }
        class Triangle : Shape
        {
            public Triangle() { }
            public Triangle(int b, int c) : base(b, c) { }
            public override double area()
            {
                return (0.5 * dim1 * dim2);
            }

            class Square : Rect
            {
                public Square() { }
                public Square(int s) : base(s, s) { }

            }
            class Geoshape {
                circle c;
                Rect R;
                Triangle T;
                Square S;
                public Geoshape(circle cr, Rect re, Triangle tr, Square sq)
                {
                    c = cr;
                    R = re;
                    T = tr;
                    S = sq;
                }
                public double totalarea()
                {
                    double sum = 0;
                    sum += c.area() + R.area() + T.area() + S.area();
                    return sum;
                }

            }

            static void m1()
            {
                Console.Write("hello there");
            }
            static void m2(Action action ) {
                action();
                Console.WriteLine("hello my friend");
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome!");
                circle c1 = new circle();
                Rect r1 = new Rect(5,6);
                Triangle tr1 = new Triangle(7,3);
                Square sq1 = new Square(5);
                Geoshape G =new Geoshape(c1, r1, tr1, sq1);

                Console.WriteLine("Hello,total area is: "+G.totalarea());

                m2(m1);
                Console.ReadKey();

            }
        }
    }
}
