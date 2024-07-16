using ConsoleApp;
using System.Globalization;
using System.Reflection.Metadata;

Demos demos = new Demos();
//demos.Strings();
//demos.NumbersFormatting();
//demos.Numbers();

//Console.ReadLine();


int a = 5;
int b = 10;
int c = 15;


//deklaracja tablicy przechowującej dane typu int
//[] - tablica
int[] array;


//inicjalizujemy zmienną nową tablicą typu int o rozmiarze 3
//tablica wypełniana jest wartościami domyślnymi zadeklarowanego typu (dla int jest to 0)
array = new int[3];

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);


//tablice są indeksowane od 0 (minimalny indeks)
//odwołujemy się do pierwszgo elemntu tablicy, czyli pod indeks 0
array[0] = 5;
array[1] = b;
//maksymalny indeks tablicy to rozmiar minus 1 (3 - 1 = 2)
//array[2] = c;
array[array.Length - 1] = c;


Console.WriteLine(array[2]);
Console.WriteLine(array[1]);
Console.WriteLine(array[0]);

Console.WriteLine($"Tablica ma rozmiar {array.Length}");

string[] inputs = new string[2];
Console.WriteLine("Podaj pierwszy bok prostokąta:");
inputs[0] = Console.ReadLine();
Console.WriteLine("Podaj drugi bok prostokąta:");
inputs[1] = Console.ReadLine();

float[] sides = new float[inputs.Length];
sides[0] = float.Parse(inputs[0]);
sides[1] = float.Parse(inputs[1]);

float area = sides[0] * sides[1];
Console.WriteLine($"Pole prostokąta to {area}");

Console.WriteLine("Napisz coś:");
string input = Console.ReadLine();
//tablica zwracana jako rezultat wywołania metody
//metoda split dzieli string na części wg wskazanego separatora

//string[] words = input.Split(" ");
string[] words = input.Split(); //bez parametru, działa jak powyżej

Console.WriteLine($"Napisałeś {words.Length} słów. Pierwsze słowo: {words[0]}, ostatnie: {words[words.Length - 1]}");
