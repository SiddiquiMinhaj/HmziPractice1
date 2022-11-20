namespace AbstractClassImplement
{
    public abstract class Figure  //this class is parent class for all 4 classes
    {

        public double width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
        public class Rectangle:Figure
        {


            public Rectangle(double width, Double Hieght)
            {

            
                this.width = width;
                this.Height = Hieght;

            }
        public override double GetArea()
        {
            return width*Height;
        }

    }

        public class Circle : Figure
        {
            public Circle(double Radius)
            {
                this.Radius = Radius;
            }
        public override double GetArea()
        {
            return Pi*Radius*Radius;
        }
     }

        public class Cone : Figure
        {
            public Cone(double Radius, double Height)
            {
                this.Radius=Radius;
                this.Height=Height;
            }
        public override double GetArea()
        {
            return Pi*Radius*(Radius*+Math.Sqrt(Height*Height+Radius*Radius));
        }


        }

       class Testfigure
    {
        static void Main()
        {

            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(45.67);
            Cone c1 = new Cone(34.98, 12.98);

            Console.WriteLine("Area of Rectangle:" + r.GetArea());
            Console.WriteLine("Area of Circle:" + c.GetArea());
            Console.WriteLine("Area of Circle:" + c1.GetArea());

            Console.ReadLine();

        }
    }
    
}