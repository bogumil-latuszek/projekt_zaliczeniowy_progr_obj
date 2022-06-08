using System;

namespace projekt_zaliczeniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            MainController mc = new MainController();
            mc.Controlleres.Add(new Create_ASCII_Controller(mc.core));
            mc.Start();
        }
    }
}
