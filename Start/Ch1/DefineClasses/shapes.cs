// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes
//NOTES:: Quiz:: What is the name of the class that all other classes in .NET eventually derive from?
 // Ans:: object
// TODO: Define a class using the "class" keyword
class Rectangle {
    // TODO: The constructor accepts parameters used to create the object
    public Rectangle(int w, int h){
        width = w;
        height = h;
    }

    // TODO: For convenience, we can have a constructor that takes one value
    public Rectangle(int side){
        width = height = side;
    }
    // for squares that have the same side size


    // TODO: Classes can define methods that return values
    public int GetArea(){
        return width * height;
    }

    // TODO: member variables hold data

    public int width;
    public  int height;
}