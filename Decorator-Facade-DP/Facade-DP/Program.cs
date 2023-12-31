﻿interface Shape
{
    void draw();
}
public class Rectangle : Shape
{
    public void draw()
    {
        Console.WriteLine("Rectangle => draw()");
    }
}

public class Square : Shape
{
    // override 
    public void draw()
    {
        Console.WriteLine("Square => draw()");
    }
}

public class Circle : Shape
{
    // override 
    public void draw()
    {
        Console.WriteLine("Circle => draw()");
    }
}


public class ShapeMaker
{
    private Shape circle;
    private Shape rectangle;
    private Shape square;

    public ShapeMaker()
    {
        circle = new Circle();
        rectangle = new Rectangle();
        square = new Square();
    }

    public void drawCircle()
    {
        circle.draw();
    }
    public void drawRectangle()
    {
        rectangle.draw();
    }
    public void drawSquare()
    {
        square.draw();
    }
}

class Program
{
    public static void Main()
    {
        ShapeMaker shapeMaker = new ShapeMaker();

        shapeMaker.drawCircle();
        shapeMaker.drawRectangle();
        shapeMaker.drawSquare();
    }
}