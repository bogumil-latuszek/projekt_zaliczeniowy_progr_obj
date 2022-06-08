using System;

namespace projekt_zaliczeniowy
{
    public class Create_ASCII_Controller : IController
    {
        public Core core;

        public Create_ASCII_Controller(Core core)
        {
            this.core = core;
        }

        public string GetDescription()
        {
            return "Rozpocznij tworzenie ASCII art na podstawie " +
                "obrazu .png ";
        }

        public bool Start()
        {
            Console.WriteLine("Rozpoczynam tworzenie ASCII art, podaj " +
                "ścieżkę do obrazu .png który będzie użyty jako podstawa");

            string user_input = Console.ReadLine();

            char[,] ascii_art = core.Create_ASCII(user_input);

            Console.WriteLine("obraz stworzony");


            bool goOn = true;
            do
            {
                Console.WriteLine("(1):wyświetl (2):zapisz (3):zakończ");

                user_input = Console.ReadLine();

                int choosen_number;
                if (Int32.TryParse(user_input, out choosen_number))
                {
                    switch (choosen_number)
                    {
                        case 1:
                            Console.WriteLine(ascii_art.ToString());
                            break;
                        case 2:
                            //zapisz
                            Console.WriteLine("zapisane");
                            break;
                        case 3:
                            goOn = false;
                            break;
                        default:
                            break;
                    }
                }

            } while (goOn);

            return true;
        }

    }
}
