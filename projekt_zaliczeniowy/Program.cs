using System;

namespace projekt_zaliczeniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            MainController mc = new MainController();
            mc.Controlleres.Add(new BasicController());
            mc.Start();
        }
    }
}
