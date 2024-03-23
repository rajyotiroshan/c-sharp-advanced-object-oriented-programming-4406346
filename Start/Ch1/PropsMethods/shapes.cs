// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Working with properties and methods
//Notes:Quiz:
//1. Properties serve as a way to expose a class' data without exposing internal implementation details.
//2. //What is the proper way to define a read/write property that represents an integer with no backing field? ==> public int MyProp { get; set; }
// Define a class using the "class" keyword
class Rectangle {
    // The constructor accepts parameters used to create the object
    public Rectangle(int w, int h) {
        width = w;
        height = h;
    }

    // For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle(int side) {
        width = height = side;
    }

    // Classes can define methods that return values
    public int GetArea() {
        return width * height;
    }

    // TODO: Define Properties that allow access to the private data
    // These are called "backing field" properties
    public int Width {
        get { return width;}
        set {width = value;}
    }

    public int Height {
        get {return height;}
        set {
            if(value < 0){
                throw new ArgumentOutOfRangeException("Height", "must be >= 0");
            }
            height = value;
        }
    }

        
    // TODO: Auto-implmeneted properties don't have a backing field
    public int BorderSize {
        get; set;
    } = 1;
    
    // Properties and member variables hold data
    int width;
    int height; 
}
