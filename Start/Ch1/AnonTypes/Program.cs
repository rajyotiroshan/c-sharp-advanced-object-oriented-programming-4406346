// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types
//Noes:: creating lightweight objects with read-only properties
// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new {
    Name = "Rajan Kumar Jha",
    Age = 45,
    Address = new {
        Street= "deohar",    
        City="Madhubani"
    }
};

Console.WriteLine($"{myobj.Name}, {myobj.Address.Street}");//Rajan Kumar Jha, deohar
Console.WriteLine($"{myobj}"); //since overrides the ToString MethodS(), { Name = Rajan Kumar Jha, Age = 45, Address = { Street = deohar, City = Madhubani } }
// Anonymous types are read-only and cannot be modified
//myobj.Name = "Jane Doe"; // will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
var myobj2 = myobj with {Name = "Jane Doe"};
Console.WriteLine($"{myobj2.Name}, {myobj2.Address.Street}");
Console.WriteLine($"{myobj2}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myobj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myobj.GetType().GetProperty("Job") !=null}");
