using System;

namespace MoreObjectPractice4._2
{
    class Program
    {
        class Rectangle
        {
            public int L;
            public int W;
        }
        class MenuItem
        {
            private int ID;
            private string Name;
            private string Description;
            private decimal Price;

            public MenuItem(int i, string n, string des, decimal pri)
            {
                ID = i;
                Name = n;
                Description = des;
                Price = pri;
            }
            public MenuItem(int i, string n, decimal pri)
            {
                ID = i;
                Name = n;
                Price = pri;
            }

            public void setName(string n)
            {
                if (n == null)
                {
                    Name = "EMPTY";
                }
                else
                {
                    Name = n;
                }
            }
            public void setPri(decimal pri)
            {
                if (pri >= 10)
                {
                    pri = 10;
                    Price = pri;
                }
                else if (pri <= 1 / 2)
                {
                    pri = 1 / 2;
                    Price = pri;
                }
            }

            public void setDescription(string des)
            {
                if (des == null)
                {
                    Description = "EMPTY";
                }
                else
                {
                    Description = des;
                }
            }
            public int getID()
            {
                return ID;
            }
            public string getName()
            {
                return Name;
            }
            public string getDescription()
            {
                return Description;
            }
            public decimal getPrice()
            {
                return Price;
            }
            public override string ToString()
            {
                return $"\n==========================\nID:{getID()} Name:{getName()} Description:{getDescription()} Price:{getPrice()}\n===============================\n";
            }

        }

        static void Main(string[] args)
        {
            MenuItem myMenu = new MenuItem(5, "footlong", "Subs", 15);
            MenuItem myMenu2 = new MenuItem(5, "footlong", 12);
            Console.WriteLine(myMenu.ToString());
            Console.WriteLine(myMenu2.ToString());


            /*So it seems that even though both the length and width were set to the same values it did not recognize that r1 and r2 were the same 
             * I assume this means == is not checking the values aka the contents of r1 and r2 do not matter its checking their reference #'s to the heap (not sure if thats correct terminology)
             * When we set r2 = r1 I assume that changes the  so that they are both 100% identical as r2 is now an identical clone of r1 both in content and reference #'s 
             * 
             * After googling it looks like this is not the case with .equals at least which is good to know and I may test using that more in the future
            */
            Rectangle r1 = new Rectangle() {L = 5, W = 5 };
            Rectangle r2 = new Rectangle();
            r2 = r1;
            if (r1 == r2)
            {
                Console.WriteLine("\nSame");
            }
            else
            {
                Console.WriteLine("\nDifferent");
            }


        }
    }
}
