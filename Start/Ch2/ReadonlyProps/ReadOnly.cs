// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using the readonly modifier for class members
//Notes::readonly can be used in
//1. get initi of empy
//2. in constrctor 
//const vs readly, const-> at compile time, readonly at runtime during constructor init. so at later after init.
public class Book {
    // Declare some private fields
    private readonly string _ISBN = "";
    private string _title = "";
    private string _author = "";

    public Book(string ISBN, string Title, string Author) {
        _ISBN = ISBN;
        _title = Title;
        _author = Author;
    }

    public void Update(string ISBN, string Title, string Author) {
       // _ISBN = ISBN;
        _title = Title;
        _author = Author;
    }

    public override string ToString() {
        return $"{_ISBN}: {_title} by {_author}";
    }
}
