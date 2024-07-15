using ConsoleApp;
using System.Globalization;

/*StringsDemo myStringsDemo = new StringsDemo();
myStringsDemo.Run();*/


int a = 11;
int b = 4;

int c = a + b;
Console.WriteLine($"{a} + {b} = {c}");
c = a - b;
Console.WriteLine($"{a} - {b} = {c}");
c = a * b;
Console.WriteLine($"{a} * {b} = {c}");
c = a / b; // część dziesiętna jest ucięta (nie zaokrąglana!)
Console.WriteLine($"{a} / {b} = {c}");
c = a % b; //reszta z dzielenia
Console.WriteLine($"{a} % {b} = {c}");


float aa = 11;
float bb = 4.0f;

float cc = aa + bb;
Console.WriteLine($"{aa} + {bb} = {cc}");
cc = aa - bb;
Console.WriteLine($"{aa} - {bb} = {cc}");
cc = aa * bb;
Console.WriteLine($"{aa} * {bb} = {cc}");
cc = aa / bb;
Console.WriteLine($"{aa} / {bb} = {cc}");

//aby wynik był poprawny przy dzieleniu dwóch intów należy jako pierwszą operację "przekształcić" int na float
//możemy to zrobić poprzez wykonanie jako pierwszą operację mnożenia przez typ o większej prezycji
cc = 1f * a / b;
Console.WriteLine($"{a} / {b} = {cc}");

//lub poprzez rzutowanie (czyli potraktowanie jednego typu jako inny (podany w nawiasie))
cc = (float)a / b;
Console.WriteLine($"{a} / {b} = {cc}");

//kolejność działań zgodna z zasadami matematyki
c = a + a * a;
Console.WriteLine($"{a} + {a} * {a} = {c}");
c = (a + a) * a;
Console.WriteLine($"({a} + {a}) * {a} = {c}");



Console.WriteLine($"byte min:{byte.MinValue} max:{byte.MaxValue}");
Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");

Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

Console.WriteLine(5 / 3.3f); //f - float
Console.WriteLine(5 / 3.3d); //d - double
Console.WriteLine(5 / 3.3m); //m - decimal

//Math to klasa zawierające funkcje przydatne w obliczeniach matematycznych
//domyślne zachowanie funkcji zaokrąglającej powoduje zaokrąglanie do wartości parzystej
Console.WriteLine( Math.Round(2.5/*, MidpointRounding.ToEven*/) );
Console.WriteLine( Math.Round(3.5) );

Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));



//formatowanie liczb
float number = 9;
Console.WriteLine(number.ToString("0#")); //09
Console.WriteLine(19.ToString("0#")); //19

Console.WriteLine($"{number:0#}"); //09
Console.WriteLine($"{19:0#}"); //09

number = 1f / 3f;
Console.WriteLine($"{number:0.##}");
Console.WriteLine($"{number:f2}");

Console.WriteLine($"{1:0.00}");
Console.WriteLine($"{1:f2}");



Console.WriteLine("Podaj pierwszy bok prostokąta:");
string input1 = Console.ReadLine();
Console.WriteLine("Podaj drugi bok prostokąta:");
string input2 = Console.ReadLine();

//parsowanie/konwersja string na int
/*int sideA = int.Parse(input1);
int sideB = int.Parse(input2);*/

//parsowanie/konwersja string na float
float sideA = float.Parse(input1);
float sideB = float.Parse(input2);

float area = sideA * sideB;
Console.WriteLine($"Pole prostokąta to {area}");