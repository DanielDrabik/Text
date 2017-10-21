using System;
using System.IO;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] objMovies = new Movie[1];
            int choice;

            do
            {
                Console.WriteLine("1. Wczytaj dane");
                Console.WriteLine("2. Wyswietl wszystkie filmy");
                Console.WriteLine("3. Dodaj film");
                Console.WriteLine("4. Wyjdz");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LoadData(ref objMovies);
                        break;
                    case 2:
                        DisplayAllMovies(objMovies);
                        break;
                    case 3:
                        AddMovie(ref objMovies);
                        break;
                    default:
                        break;
                }
            } while (choice != 4);

        }

        public static void LoadData(ref Movie[] objMovies)
        {
            StreamReader reader = new StreamReader("Movies.txt");
            int size = Convert.ToInt32(reader.ReadLine());
            objMovies = new Movie[size];

            for (int index = 0; index < objMovies.Length; index++)
            {
                objMovies[index] = new Movie();
                objMovies[index].Title = reader.ReadLine();
                objMovies[index].Director = reader.ReadLine();
                objMovies[index].Year = Convert.ToInt32(reader.ReadLine());
            }

            reader.Close();

        }

        public static void DisplayAllMovies(Movie[] objMovies)
        {
            // Wyswietl wszystkie informacje o przechowywanych filmach korzystając z metody DisplayInformation()   
            
        }

        public static void AddMovie(ref Movie[] objMovies)
        {
            // Zainicjuj StreamWritera tak aby nadpisywał istniejący plik
            

            // Zainkrementuj liczbe filmow i wpisz do pliku
           

            // Stworz nowy obiekt
            

            // Zbierz informacje od użytkownika
            

            // Wprowadź nowy film do pliku
            

            // Wprowadź wszystkie poprzednie filmy
            

            // Zamknij plik
           

            // Zaktualizuj tablicę objMovies
            LoadData(ref objMovies);
        }
    }
}
