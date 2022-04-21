using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voris
{
    class grandparent {
        public void show_grand() {
            Console.WriteLine("Bu bobo sinf");
        }
    }

    class parent: grandparent {
        protected int son=10;
        
        public void show_parent() {
            Console.WriteLine("Bu ota sinf");
        }
    }

    class child:parent {
        
        public void XimoyalanganMaydondanFoydalanish() {
            child obj = new child();
            Console.WriteLine(obj.son);
        }
        
        public void show_child(){
        Console.WriteLine("Bu bola sinf");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            child obj = new child();
            obj.show_grand();

            Console.ReadKey();
        }
    }
}
