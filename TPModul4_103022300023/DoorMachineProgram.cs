//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TPModul4_103022300023
//{
//    class Program
//    {
//        static void Main()
//        {
//            DoorMachine door = new DoorMachine();

//            while (true)
//            {
//                Console.WriteLine("Buka : Membuka pintu\nKunci : Mengunci pintu\nExit : Keluar\n");
//                Console.Write("Input: ");
//                string command = Console.ReadLine().ToLower();

//                if (command == "buka")
//                    door.BukaPintu();
//                else if (command == "kunci")
//                    door.KunciPintu();
//                else if (command == "exit")
//                    break;
//                else
//                    Console.WriteLine("\nMasukkan input yang sesuai");
//            }
//        }
//    }
//}
