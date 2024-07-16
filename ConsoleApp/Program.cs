using ConsoleApp;
using Microsoft.VisualBasic;


Demos demos = new Demos();
//demos.Strings();
//demos.NumbersFormatting();
//demos.Numbers();
//demos.Arrays();

//Console.ReadLine();


//tworzymy nową listę. Lista po inicjalizacji jest pusta.
List<string> listOfStrings = new List<string>();
//List<string> listOfStrings = new();
//List<string> listOfStrings = [];

Console.WriteLine(listOfStrings.Count);

//dodajemy nowy element do listy, rozmiar tablicy się zwiększa
listOfStrings.Add("!");
listOfStrings.Add("ala");
listOfStrings.Add("kota");

Console.WriteLine(listOfStrings.Count);


//stawiamy element na konkretny indeks listy - pozostałe ementy przesuwają się
listOfStrings.Insert(2, "ma");


listOfStrings.Add("!");
listOfStrings.Add("!");

//usuwamy element pod indeksem 2 - rozmiar listy się zmniejsza
listOfStrings.RemoveAt(2);

//usuwamy element wg wartości - jeśli występuję więcej takich elementów, to usuwany jest pierwszy w kolejności
listOfStrings.Remove("!");

var indexOfExclamantionMark = listOfStrings.IndexOf("!"); //pytamy listę o index wskazanego elementu
listOfStrings.Insert(indexOfExclamantionMark + 1, "@");

//w listach odwołujemy się do elementów po indeksach (tak jak w tablicach)
listOfStrings[listOfStrings.Count - 1] = "?";


Console.WriteLine(listOfStrings[1]);

//przekształcenie tablicy do listy
listOfStrings = Console.ReadLine().Split().ToList();
Console.WriteLine($"Lista ma rozmiar: {listOfStrings.Count}");