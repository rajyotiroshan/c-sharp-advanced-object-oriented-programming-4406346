// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog=  new Dog {Name="Fido", Age=4, IsTrained = true};

Cat cat = new Cat {Name="Mr. Miwew", Age=3, IsDeclawed = false};
Console.WriteLine($"Dog: {dog.Name}, {dog.Age}");//
Console.WriteLine($"Cat: {cat.Name}, {cat.Age}");
// TODO: Initializers can be used on anonymous types
var pet = new  {Name="charlie", Age=5};

// TODO: Collections can also be initialized this way
int[] numbers = new int[] {1,2,3,4,5,6};
Console.WriteLine(numbers);
// TODO: Initialize a collection with a set of objects

PetOwner owner = new()
{
    Name = "rajan",
    Pets = new List<Pet> {
        new Dog {Name="Rajan", Age=4},
        new Cat {Name="vivek", Age=5},
        new Dog {Name="Samit", Age=6},
    }
};
Console.WriteLine($"{owner.Name}'s Pets");

foreach(Pet p in owner.Pets) {
    Console.WriteLine(p.Name);
}

