using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_zaliczeniowy
{
    class Controller
    {
        private Core core;
        private UI ui;

        public Controller()
        {
            this.core = new Core();
            this.ui = new UI();
        }
    }
}
