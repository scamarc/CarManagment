using CarManagment.Domain.Entity;
using CarManagment.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagment.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService() 
        {
            Initialize();
        }
        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach(var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
        public int GetMenuId(List<MenuAction> menu)
        {
            //var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("_________________________________");
                Console.WriteLine("|   WYBIERZ OPCJĘ Z MENU  !     |");
                Console.WriteLine("|_______________________________|");
                Console.WriteLine("|                               |");
                for (int i = 0; i < menu.Count; i++)
                {
                    Console.WriteLine($"|  {menu[i].Id}. {menu[i].Name}  |");
                }
                Console.WriteLine("___________________________________");
                var operation = Console.ReadKey();
                Console.WriteLine(" <= WYBRANO");
                Console.WriteLine("___________________________________");
                int typeId;
                if (Int32.TryParse(operation.KeyChar.ToString(), out typeId))
                {
                    var entity = menu.FirstOrDefault(p => p.Id == typeId);
                    if (entity != null)
                    {
                        return typeId;
                    }
                    else
                        Console.WriteLine("Cyfra poza zakresem menu!");
                }
                else Console.WriteLine("Znak nie jest cyfrą!"); //błąd znak nie jest cyfrą
                Console.ReadKey();
            }
        }
        private void Initialize()
        {
            AddItem(new MenuAction(0, "- Zakończ program       ", "Main"));
            AddItem(new MenuAction(1, "- Lista samochodów      ", "Main"));
            AddItem(new MenuAction(2, "- Lista danego typu     ", "Main"));
            AddItem(new MenuAction(3, "- Dane samochodu        ", "Main"));
            AddItem(new MenuAction(4, "- Dodaj nowy pojazd     ", "Main"));
            AddItem(new MenuAction(5, "- Usuń pojazd           ", "Main"));
            AddItem(new MenuAction(0, "- ANULUJ                ", "AddNewItemMenu"));
            AddItem(new MenuAction(1, "- Petrol                ", "AddNewItemMenu"));
            AddItem(new MenuAction(2, "- Hybrid                ", "AddNewItemMenu"));
            AddItem(new MenuAction(3, "- Electric              ", "AddNewItemMenu"));
        }
    }
}
