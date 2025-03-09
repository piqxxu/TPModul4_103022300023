using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul4_103022300023
{
    public class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci; 
            Console.WriteLine("Pintu terkunci");
        }

        public void KunciPintu()
        {
            if (currentState == State.Terkunci)
            {
                Console.WriteLine("\nPintu sudah terkunci");
            }
            else
            {
                currentState = State.Terkunci;
                Console.WriteLine("\nPintu terkunci");
            }
        }

        public void BukaPintu()
        {
            if (currentState == State.Terbuka)
            {
                Console.WriteLine("\nPintu sudah terbuka");
            }
            else
            {
                currentState = State.Terbuka;
                Console.WriteLine("\nPintu tidak terkunci");
            }
        }
    }
}
