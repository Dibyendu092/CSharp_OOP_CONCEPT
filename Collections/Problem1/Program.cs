using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Collections.Problem1
{
    internal class Program
    {
       /*static void Main(string[] args)
        {
            HallBO hallBO = new HallBO();
            List<Hall> hallList = new List<Hall>();
            bool isExit = false;
            while (true)
            {
              
                Console.WriteLine("1.Add Hall\n2.Remove Hall\n3.Exit\nEnter the choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter hall detail:");
                        string hallDetail = Console.ReadLine();
                        HallBO hallBO1 = new HallBO();
                        hallList.Add(hallBO1.CreateHall(hallDetail));
                        Console.WriteLine("Hall Created Successfully");
                        break;
                    case 2:
                        Console.WriteLine("Total " + hallList.Count + " Halls");
                        Console.WriteLine("Enter the index:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        HallBO hallBO2 = new HallBO();
                        bool k = hallBO2.RemoveHallFromList(hallList, x-1);
                        int flag = 0;
                        if (flag== 0)
                        {
                            
                            if (k == false)
                            {
                                Console.WriteLine("Hall list empty");
                                flag = 1;
                                

                            }
                            else
                            {

                                hallBO2.DisplayHalls(hallList);
                            }
                        }
                        else
                        {
                            Console.WriteLine("List is Empty");
                            Environment.Exit(0);
                        }
                        break;
                    case 3:
                        isExit = true;
                        break;
                }
                if (isExit)
                    break;
            }

        }*/
    }
}
