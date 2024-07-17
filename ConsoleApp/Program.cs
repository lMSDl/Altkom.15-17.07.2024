using ConsoleApp;
using Models;

Demos demos = new Demos();
//demos.Strings();
//demos.NumbersFormatting();
//demos.Numbers();
//demos.Arrays();
//demos.IfElse();
//demos.WhileDoWhile();
//demos.For();

//Console.ReadLine();


Console.WriteLine(typeof(Person).Name);
Console.WriteLine(typeof(Person).Namespace);
Console.WriteLine(typeof(Person).FullName);

Person person = new Person("Zenon", "Zenowski", 80);
Console.WriteLine(person.GenerateBio());
person.SetName("     ala      ");
Console.WriteLine(person.GetName());

person.LastName = "AloWska";
Console.WriteLine(person.LastName);

person.Age = 30;

Console.WriteLine(person.GenerateBio());
person.ChangeNamesToTitleCase();
Console.WriteLine(person.GenerateBio());




Console.WriteLine("-----");


/* Tworzenie pierwszego autora "Jan Nowak" */
Person person1 = new Person("Jan");
person1.LastName = "Nowak";

/* Tworzenie drugiego autora "Jan Nowak" */
Person person2 = new Person("Kamil");
person2.LastName = "Kowalski";

/* Tworzenie pierwszej książki */
Book book1 = new Book("Grunwald", person1);

/* Tworzenie drugiej książki */
Book book2 = new Book("Miś uszatek", person1);

/* Tworzenie trzeciej książki */
Book book3 = new Book("Muninki", person2);

Library library = new Library();
library.Add(book1);
library.Add(book2);
library.Add(book3);
library.ShowBooks();


Console.WriteLine("-----");

Car car = new Car("Skoda", "Octavia", 2022);

Console.WriteLine(car.GetInformations());
car.Fuel(0.5f);
Console.WriteLine(car.GetInformations());
car.Fuel(0.6f);
Console.WriteLine(car.GetInformations());
car.Drive(100);
Console.WriteLine(car.GetInformations());
car.Drive(623);
Console.WriteLine(car.GetInformations());
car.Drive(500);
Console.WriteLine(car.GetInformations());

