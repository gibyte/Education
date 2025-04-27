using PatternPrototype;

Dog dog1 = new Dog { Species = "Canine", Age = 3, Breed = "Labrador" };
Dog dog2 = dog1.Clone();

Console.WriteLine($"Dog 1: {dog1.Species}, {dog1.Age} years old, {dog1.Breed}");
Console.WriteLine($"Dog 2: {dog2.Species}, {dog2.Age} years old, {dog2.Breed}");

Console.ReadLine();