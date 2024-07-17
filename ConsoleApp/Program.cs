﻿using ConsoleApp;
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


Person person2 = new Person();



