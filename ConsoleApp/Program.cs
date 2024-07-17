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

Person person = new Person();
person.SetName("     ala      ");
Console.WriteLine(person.GetName());

