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
    }
}
