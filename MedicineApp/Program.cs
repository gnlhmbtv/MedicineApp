using Business.Services;
using Entities.Models;
using System;
using Utilies.Helper;

namespace MedicineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DrugTypeServices drugTypeServices = new DrugTypeServices();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Welcome");
            while (true)
            {
                Helper.ChangeTextColor(ConsoleColor.Green,"1-Create Drug Type, 2-Update Drug Type, 3- Delete Drug Type" +
                    "4-Get Drug Type with Id, 5-Get Drug Type with TypeName, 6-All Drug Type, 7-Get Drug Type with drug count");
                Helper.ChangeTextColor(ConsoleColor.Yellow, "Select option number");
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu > 0 && menu < 8) 
                {
                    switch (menu)
                    {
                        case 1:
                            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter type name:");
                            string name = Console.ReadLine();
                            EnterCount: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter drug count:");
                            string count = Console.ReadLine();
                            int maxCount;
                            bool isTrueCount = int.TryParse(count, out maxCount);
                            if (isTrueCount)
                            {
                                DrugType drugtype=new DrugType { TypeName=name,DrugCount=maxCount};
                                if (drugTypeServices.Create(drugtype)!=null)
                                {
                                    Helper.ChangeTextColor(ConsoleColor.Green, $"{drugtype.TypeName} created");
                                    break;
                                }
                                else
                                {
                                    Helper.ChangeTextColor(ConsoleColor.Red, "Something wrong");
                                    break;
                                }
                            }
                            else
                            {
                                Helper.ChangeTextColor(ConsoleColor.Red, "Enter correct size");
                                goto EnterCount;
                            }
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            Helper.ChangeTextColor(ConsoleColor.Yellow, "All Drug Types:");
                            foreach (DrugType drugType in drugTypeServices.GetAll())
                            {
                                Helper.ChangeTextColor(ConsoleColor.Blue, $"{drugType.Id}{drugType.TypeName}");
                            }
                            break;
                        case 7:
                            break;
                        
                    }
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please select correct option");
                }
            }
        }
    }
}
