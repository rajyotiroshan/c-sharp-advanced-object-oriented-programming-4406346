// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Define a base class that represents the concept of a 2-dimensional shape
class Shape2D {
    public Shape2D() {}

    // TODO: Methods must be marked as "virtual" to allow overriding
    public virtual float GetArea(){
        return 0.0f;
    }

    // TODO: All classes in .NET derive from Object, so we get some methods for free
    // ToString() returns a string representation of the object
    public override string ToString() =>  $"This Object is a '{GetType()}'";
    // GetType() returns the type of the object
}

// Derive a Circle class that inherits from the base Shape2D
class Circle : Shape2D {
    public Circle(int r) {
        radius = r;
    }

    // TODO: Override the GetArea() function for the Circle
    public override float GetArea()
    {
        return (3.14f*(radius*radius));
    }
    int radius;
}

// Derive a Rectangle class that inherits from the base Shape2D
class Rectangle : Shape2D {
    public Rectangle(int w, int h) {
        width = w;
        height = h;
    }

    // TODO: Override the GetArea() function for the Rectangle
    public override float GetArea()
    {
        return (width * height)
;    }
    int width;
    int height; 
}

// TODO: Derive a Square class that inherits from the base Rectangle
class Square: Rectangle {
    public Square(int side): base(side, side){} //init base class with side

}