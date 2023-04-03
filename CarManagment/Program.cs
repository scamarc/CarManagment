using System;
using System.Collections.Generic;
using System.Linq;
using CarManagment.Domain.Entity;
using CarManagment.App.Abstract;
using CarManagment.App.Concrete;
using CarManagment.App.Manager;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Xml.Serialization;
using CarManagment.Helpers;

namespace CarManagment 
{
    class Program
    {
        static void Main(string[] args)
        {
  
            MenuActionService actionService = new MenuActionService();
            ItemService itemService = new ItemService();
            ItemManager itemManager = new ItemManager(actionService, itemService);

            Console.Clear();
            Console.WriteLine("_________________________________");

            Console.WriteLine("|   C A R   M A N A G M E N T   |");
            Console.WriteLine("|_______________________________|");
            for(; ;)
            {
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                int id = actionService.GetMenuId(mainMenu);
                switch (id)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("_________________________________");
                        Console.WriteLine("|  D O   Z O B A C Z E N I A    |");
                        Console.WriteLine("|_______________________________|");
                        return;
                    case 1:
                        itemManager.CarView();
                        Console.ReadKey();
                        break;
                    case 2:
                        itemManager.CarViewTypId();
                        Console.ReadKey();
                        break;
                    case 3:
                        itemManager.ListCarById();
                        break;
                    case 4:
                        itemManager.AddNewCar();
                        break;
                    case 5:
                        itemManager.RemoveCarById();
                        break;
                    default:
                        break;
                }
            }        
        }
    }
}

