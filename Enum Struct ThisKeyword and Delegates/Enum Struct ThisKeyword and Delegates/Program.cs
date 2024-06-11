using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Struct_ThisKeyword_and_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*public enum City { Karachi, Lahore, Islamabad };*/
                /* int c = (int) City.Lahore;
                 Console.WriteLine(c);*/
                /*  start:
                  Console.WriteLine("Please Enter 0,1 Or 2");
                  int user_input = int.Parse(Console.ReadLine());
                  if (user_input == 0)
                  {
                      Console.WriteLine("You have selected " + City.Karachi);
                  }
                  else if (user_input == 1)
                  {
                      Console.WriteLine("You have selected " + City.Lahore);
                  }

                  else if (user_input == 2)
                  {
                      Console.WriteLine("You have selected " + City.Islamabad);
                  }

                  else
                  {
                      Console.WriteLine("Please Enter Valid Value");
                      goto start;
                  }*/
                /*
                            Mystruct myobj = new Mystruct(20,20);
                            myobj.Calculate();*/

                Student obj = new Student();
                detail_ref delegate_obj = new detail_ref(obj.Details2);
                detail_ref delegate_obj2 = new detail_ref(obj.Details);
                delegate_obj();
                delegate_obj2.Invoke();

                /*    myobj.Details();*/
                Console.ReadKey();
            }


        }

        /*   public struct Mystruct
           {
               public int w , h;
               public Mystruct(int width ,int height)
               {
                   this.w = width;
                   this.h = height;
               }

               public void Calculate()
               {
                   Console.WriteLine("Area Of rectagle :" + (w*h));
               }

           }*/
}
