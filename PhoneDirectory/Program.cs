using System;

namespace PhoneDirectory
{
    public class Directory
    {
        public static void Main(string[] args)
        {


            DirectoryActionsMethods allActions = new DirectoryActionsMethods();

            Boolean status = true;
            while (status)
            {
                
                Console.WriteLine("Welcom\n" +
                    "0-Save phone number\n" +
                    "1-Delete phone number\n" +
                    "2-Update phone number\n" +
                    "3-Sort by phone number\n" +
                    "4-Reverse Sort by phone number\n" +
                    "5-Search Phone number" +
                    "7-Quit");


                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        allActions.add();
                        break;
                    case 1:
                        allActions.remove();
              
                        break;
                    case 2:
                        allActions.update();
                       
                        break;
                    case 3:
                        allActions.OrderbyAlphabetical();
                       
                        break;
                    case 4:
                        allActions.OrderReverse();
                       ;
                        break;
                    case 5:
                        allActions.search();
                        break;
                    case 6:
                        status = false;
                        break;


                }
            }
        }
    }
}