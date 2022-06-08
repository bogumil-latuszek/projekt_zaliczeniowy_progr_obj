using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_zaliczeniowy
{
    public interface IController
    {
        string GetDescription();
        bool Start( );
    }

    public class BasicController : IController
    {
        public virtual string GetDescription() { return "bazowa deskrypcja";  }
        public virtual bool Start() { Console.WriteLine("bazowe działanie"); return true; }
    }

    public class Create_ASCII_Controller : IController
    {
        public string GetDescription()
        {
            return "Rozpocznij tworzenie ASCII art na podstawie" +
                "obrazu .png ";
        }

        public bool Start()
        {
            Console.WriteLine("Rozpoczynam tworzenie ASCII art, podaj" +
                "ścieżkę do obrazu .png który będzie użyty jako podstawa");

            

            return true;
        }

    }

    class MainController : IController
    {   
        public Core core { get; set; }
        public  UI ui { get; set; }
        public List<IController> Controlleres { get; set; }

        public MainController()
        {
            this.core = new Core();
            this.ui = new UI();
            Controlleres = new List<IController>();
        }
        public string GetDescription() { return "główny kontroler"; }


        public bool Start()
        {
            bool goOn = true;
            do
            {
                Console.WriteLine("Wybierz opcje:");
                for (int i = 0; i < Controlleres.Count; i++)
                {
                    Console.WriteLine($"({i}): " +
                        $"{Controlleres[i].GetDescription()}, ");
                }

                string user_input = Console.ReadLine();

                int choosen_number;
                if(Int32.TryParse(user_input, out choosen_number))
                {
                    for (int i = 0; i < Controlleres.Count; i++)
                    {
                        if(choosen_number == i)
                        {
                            Controlleres[i].Start();
                            break;
                        }
                    }
                }

            } while (goOn);
            return true;

        }
    }
}
