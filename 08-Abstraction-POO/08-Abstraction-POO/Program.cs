
Shape[] shapes = new Shape[2];
shapes[0] = new Rectangle(5 , 10);
shapes[1] = new Circle(360);

Console.WriteLine(shapes[0].Area());
Console.WriteLine(shapes[1].Area());

public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{

    private double Width { get; set; }
    private double Height { get; set; }

    public Rectangle(double width, double height)
    {  Width = width;
       Height = height; 
    }
    public override double Area()
    {
       return Width * Height;

    }

}
public class Circle : Shape
{

    private double Radio{ get; set; }


    public Circle(double radius)
    {
        Radio = radius;
        
    }
    public override double Area()
    {
        return Math.PI * Math.Pow (Radio, 2);
    }


}