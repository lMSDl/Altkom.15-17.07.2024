namespace ConsoleApp
{
    internal class Demos
    {
        public void Strings()
        {
            //wywołanie funkcji statycznej z klasy Console z parametrem typu string
            Console.WriteLine("Hello, World!");

            Console.Write("Hello, World!"); //WriteLine stawia znak nowej linii na koniec (enter), a funkcja Write - nie

            /* wywołanie funkcji statycznej z klasy Console,
               która nie przyjmuje parametrów */
            Console.WriteLine();

            //deklaracja zmiennej o typie string (ciąg/łańcuch znaków) i nazwie helloVariable
            string helloVariable;

            //nie możemy używać niezainicjalizowanej zmiennej
            //Console.WriteLine(helloVariable);

            //inicjalizacja zmiennej - pierwsze przypisanie wartości
            helloVariable = "Hello";

            //przekazujemy naszą zmienną jako parametr funkcji
            Console.WriteLine(helloVariable);
            Console.WriteLine(helloVariable);

            //deklaracja z inicjalizacją
            string target = "World";
            Console.WriteLine(target);

            //zmiana wartości - każde kolejne przypisanie wartości
            helloVariable = "Hi";
            Console.WriteLine(helloVariable);

            string output;
            //łączenie stringów za pomocą operatora +
            output = helloVariable + ", " + target + "!"; // łączenie stringów to "wyprodukowanie" nowego stringa na podstawie połączenia innych
                                                          //output = string.Concat(helloVariable, ", ", target, "!"); //operator + jest odpowiednikiem takiego wywołania funkcji łączenia stringów

            Console.WriteLine(output);

            string myFormat = "{0}, {1}!"; //wartości w nazwiasach oznaczają indeks parametru, który ma być wstawiony w to miejsce
            output = string.Format(myFormat, helloVariable, target); //łączenie stringów za pomocą funkcji string.Fomat

            Console.WriteLine(output);

            Console.WriteLine("Podaj imię:");
            target = Console.ReadLine();

            output = $"{helloVariable}, {target}!"; //łączenie wykorzystujące interpolację (string interpolowany)

            Console.WriteLine(output);

            //Lenth - właściwość (brak nawiasów odróżnia ją od metody) - przetrzymuje dane o długości stringa
            output = $"Długość dotychczasowej zawartości zmiennej \"output\" to \t {output.Length}"; //ukośnik opadający aktywuje znak specjalny/zastrzeżony
            Console.WriteLine(output);

            output = $"Długość dotychczasowej zawartości zmiennej output to {output.Count()}";
            Console.WriteLine(output);

            //stringów nie możemy edytować, żeby zmienić wartość należy wytworzyć nowego stringa i przypisać pod zmienną
            //zastąpienie części znaków - czułe na wielkość liter
            output = output.Replace("dotychczasowej", "tymczasowej");
            Console.WriteLine(output);

            //zastąpienie części znaków - niezależne od wielkości liter
            output = output.Replace("Tymczasowej", "dotychczasowej", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(output);

            //wycinanie "podstringów"
            output = output.Substring(3, output.Length - 3 - 6); //obliczamy ile zanków usunąć z końca
            Console.WriteLine(output);

            string someString = "ala ma kota";
            string anotherString = "Ala ma kota";

            bool isEqual;

            //= operator przypisania
            // == - operator porównania, dla string działa tak samo jak Equals
            isEqual = someString == anotherString;
            Console.WriteLine(isEqual);

            //Equals porównuje czy obiekty są tym samym obiektem. Produktem metody jest zmienna bool (prawda/fałsz)
            isEqual = someString.Equals(anotherString);
            Console.WriteLine(isEqual);

            //porównanie z ignorowaniem wielkości znaków
            isEqual = someString.Equals(anotherString, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(isEqual);


            string name = Console.ReadLine();
            Console.WriteLine($"*{name}*");
            Console.WriteLine($"*{name.Trim()}*");
            Console.WriteLine($"*{name.TrimEnd()}*");
            Console.WriteLine($"*{name.TrimStart()}*");

            //usuwanie wskazanego znaku przez sparametryzowanie metody wskazanym znakiem
            Console.WriteLine($"*{name.Trim().Trim('ł')}*");
        }

        public void NumbersFormatting()
        {
            string strSec, outStr;
            int nSec, nDays, nMins, nHours;

            Console.WriteLine("Podaj ilość sekund");

            strSec = Console.ReadLine();
            nSec = int.Parse(strSec);

            Console.WriteLine(nSec);

            nDays = nSec / (24 * 60 * 60);
            nHours = (nSec - nDays * 24 * 60 * 60) / (60 * 60);
            nMins = (nSec - nDays * 24 * 60 * 60 - nHours * 60 * 60) / 60;
            nSec = (nSec - nDays * 24 * 60 * 60 - nHours * 60 * 60 - nMins * 60);

            Console.WriteLine($"Dni:{nDays}");
            Console.WriteLine($"Godziny:{nHours}");
            Console.WriteLine($"Min:{nMins}");
            Console.WriteLine($"Sec:{nSec}");

            Console.WriteLine("Sekundy po przeliczeniu na format D.HH:MM:SS");
            outStr = String.Format("{0:0#}.{1:0#}:{2:0#}:{3:0#}", nDays, nHours, nMins, nSec);
            Console.WriteLine(outStr);
            outStr = $"{nDays:0#}.{nHours:0#}:{nMins:0#}:{nSec:0#}";
            Console.WriteLine(outStr);
            outStr = nDays.ToString("#") + "." + nHours.ToString("0#:") + nMins.ToString("0#:") + nSec.ToString("0#");
            Console.WriteLine(outStr);
        }

        public void Numbers()
        {

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
            Console.WriteLine(Math.Round(2.5/*, MidpointRounding.ToEven*/));
            Console.WriteLine(Math.Round(3.5));

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




            int intValue = 5;
            long longValue = intValue;

            Console.WriteLine(longValue);

            //rzutowanie - chcąc przypisać wartość o wyższej prezycji do zmiennej o niższej precyzji musimy zastosować rzutowanie
            intValue = (int)longValue;
            Console.WriteLine(intValue);

            //longValue = 927623451892634198L;
            longValue = 2147483647 + 1L;
            Console.WriteLine(longValue);

            intValue = (int)longValue;
            Console.WriteLine(intValue);


            float floatValue = 4.5f;
            double doubleValue = floatValue;
            Console.WriteLine(doubleValue);
            doubleValue = 0.33333333333333;
            floatValue = (float)doubleValue;
            Console.WriteLine(floatValue);
        }

        public void Arrays()
        {
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
        }

        public void Lists()
        {
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
        }

        public void IfElse()
        {
            Console.WriteLine("Podaj bok kwadratu:");
            string input = Console.ReadLine();

            //int side = int.Parse(input);
            int side;
            bool parseSuccess = int.TryParse(input, out side);

            if (!parseSuccess)
            {
                Console.WriteLine("Błędna wartość!");
            }
            else
            {
                //if sprawdza warunek w nawiasie i jeśli jest on prawdziwy, to wykonuje się blok kodu pod nim
                if (side < 0)
                {
                    Console.WriteLine("Nie mogę policzyć obwodu z ujemnego rozmiaru");
                }
                // jeśli poprzedni warunek nie jest spełniony, to sprawdzany jest kolejny if
                // else if - może występować wielokrotne
                else if (side > 0)
                {
                    Console.WriteLine($"Kwadrat ma obwód {side * 4}");
                }
                //else - wykonuje blok kodu w każdym innym przypadku
                else /*if(side == 0)*/
                {
                    Console.WriteLine("Kwadrat nie instnieje");
                }


                //jeżeli używany else, to tylko jeden blok kodu zostanie wykonany i sprawdzanie warunków zakończy się w przypadku wejścia w któryś z bloków
                //jeżeli nie używany else, to każdy if będzie traktowany osobno i warunek będzie sprzwdzany niezależnie
                //wniosek else jest też łącznikiem między kolejnymi if'ami

                if (side != 0)
                {
                    Console.WriteLine("Bok jest różny od 0");
                }
                if (side == 0)
                {
                    Console.WriteLine("Bok jest równy 0");
                }
            }

            bool result = side == 0; //== - porównanie
            result = side != 0; //!= - nierówność
            result = !(side == 0); // ! - zaprezeczenie wyrażenia logicznego
            result = side < 0; // < - mniejsze
            result = side > 0; // > - większe
            result = side <= 0; // <= - mniejsze lub równe
            result = side >= 0; // >= - większe lub równe

            result = side < 0 || side == 0; // || - logiczne lub (OR)
            result = side > 0 && side <= 10; // && - logiczne i (AND) 


        }

        public void Switch()
        {
            Console.WriteLine("Podaj bok kwadratu:");
            string input = Console.ReadLine();

            int side;
            bool parseSuccess = int.TryParse(input, out side);

            if (!parseSuccess)
            {
                Console.WriteLine("Błędna wartość!");
            }
            else
            {

                //switch - przyjmuje parametr, kóry jest porównywany z listą przypadków (case)
                switch (side)
                {
                    //case - rozpatrywany przypadek
                    //wiele case'ow może być przypisanych do tego samego kodu
                    case < 0:
                        //kod wykonywany jest od case do break - nie ma potrzeby stosowaniea klamerek {}
                        //case musi kończyć się instrukją break - przerywająca wykonywanie swticha
                        Console.WriteLine("Nie mogę policzyć obwodu z ujemnego rozmiaru");
                        break;
                    case > 0:
                        Console.WriteLine($"Kwadrat ma obwód {side * 4}");
                        break;
                    //default - odpowiedniek else, czyli wykonanie kodu, jeśli nie znaleziono odpowiedniego case
                    default:
                        Console.WriteLine("Kwadrat nie instnieje");
                        break;
                }
            }



            Console.WriteLine("podaj wartość A:");
            string a = Console.ReadLine();
            Console.WriteLine("podaj wartość B:");
            string b = Console.ReadLine();

            float valueA, valueB;

            if (!(float.TryParse(a, out valueA) && float.TryParse(b, out valueB)))
            {
                Console.WriteLine("Błędne dane!");
            }
            else
            {

                Console.WriteLine("Wprowadź znak operacji:");
                string operation = Console.ReadLine();

                float result;

                switch (operation)
                {
                    case "+":
                        result = valueA + valueB;
                        break;
                    case "-":
                        result = valueA - valueB;
                        break;
                    case "*":
                        result = valueA * valueB;
                        break;
                    case "/":
                        result = valueA / valueB;
                        break;
                    case "^":
                        result = (float)Math.Pow(valueA, valueB);
                        break;
                    default:
                        Console.WriteLine("Nieznana operacja!");
                        return; //przerywa wykonywanie funkcji
                }

                Console.WriteLine($"{valueA} {operation} {valueB} = {result}");
            }
        }

        public void WhileDoWhile()
        {
            bool stop = false;

            //while - pętla która trwa gdy jej parametr jest true, parametr jest sprawdzany przed każdym wejściem do pętli
            // jeśli przy pierwszym wejściu parametr będzie false, to pętla się nigdy nie wykona
            while (!stop)
            //while(true) //= pętla nieskończona
            {
                Console.Clear();
                Console.WriteLine("1. Stringi; 2. Liczby; 3. Formatowanie");
                Console.WriteLine("Co chcesz zrobić?");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Strings();
                        break;
                    case "2":
                        Numbers();
                        break;
                    case "3":
                        NumbersFormatting();
                        break;
                    case "exit":

                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Brak wskazanej opcji");
                        break; //break wewnątrz switcha nie "propaguje" do while, więc nie przerywa pętli
                }

                //if (stop)
                //    break; //break przerywa pętlę
            }


            bool finish;

            //do-while - sprawdza warunek po wykonaniu ciała - zapewnia, że zostanie ono wykonane co najmniej raz
            //pozwala to wyeliminować inicjalizację zminnych przed wejściem do pętli
            do
            {
                Console.WriteLine("Co chcesz zrobić?");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "exit":
                        finish = true;
                        break;
                    default:
                        finish = false;
                        Console.WriteLine(operation);
                        break;
                }
            } while (!finish);




            int userValue1 = RequestForInt();

            Console.WriteLine($"{userValue1} to poprawna wartość!");

            int userValue2 = RequestForInt();

            Console.WriteLine($"{userValue2} to poprawna wartość!");
        }


        public int RequestForInt()
        {
            bool success;
            int userValue;
            string userInput;
            do
            {
                Console.WriteLine("Podaj cyfrę:");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out userValue));

            return userValue; //return służy do przerwania funkcji i zwrócenia wskazanej wartości jako wynik działania funkcji
        }
    }
}