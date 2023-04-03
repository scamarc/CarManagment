using CarManagment.Domain.Entity;
using CarManagment.App.Abstract;
using CarManagment.App.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarManagment.App.Manager
{
    public class ItemManager
    {
        private readonly MenuActionService _actionService;
        private IService<Car> _itemService;

        public ItemManager(MenuActionService actionService, IService<Car> itemService)
        {
            _itemService = itemService;
            _actionService = actionService;
        }

     
        public int AddNewCar()
        {
            var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            int typeId = _actionService.GetMenuId(addNewItemMenu);
            if (typeId == 0)
            {
                return 0;
            }
            else if(typeId < 0)
            {
                return typeId; //błąd -1 lub -2
            }
            else 
            {
                Console.WriteLine(" Podaj nazwę dla dodawanego obiektu: ");
                var name = Console.ReadLine();
                var lastId = _itemService.GetLastId();
                Car item = new Car(lastId + 1, name, typeId, 1980, DateTime.Now, DateTime.Now);
                _itemService.AddItem(item);
                return item.Id;
            }          
        }

        public void CarView()
        {
            //_itemService.View();
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("|          L I S T A  S A M O C H O D Ó W             |");
            Console.WriteLine("|_____________________________________________________|");
            Console.WriteLine("|                                                     |");
            foreach (var car in _itemService.Items)
            {
                string insuranceDate = car.InsuranceData.ToString("dd/MM/yyyy");
                string technicalDate = car.TechnicalData.ToString("dd/MM/yyyy");
                Console.WriteLine($"  {car.Id}   =>  {car.Name} , {car.TypeId}, {car.EngineCapacity}, {insuranceDate}, {technicalDate} ");
                //Console.WriteLine($"  {car.Id}   =>  {car.Name}   ");
            }
            Console.WriteLine("|_____________________________________________________|");

        }

        public void CarViewTypId()
        {
            var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            int typeId = _actionService.GetMenuId(addNewItemMenu);
            if (typeId != 0)
            {
                //_itemService.View(typeId);
                //CarType carType = typId; 
                Console.WriteLine("____________________________________");
                Console.WriteLine("|                                  |");
                Console.WriteLine("|  L I S T A  S A M O C H O D Ó W  |");
                Console.WriteLine("|__________________________________|");
                Console.WriteLine($" Samochody typId = {typeId}         ");
                foreach (var car in _itemService.Items)
                {
                    if (car.TypeId == typeId)
                    {
                        Console.WriteLine($"{car.Id} => {car.Name}");
                    }

                }
            }
        }

        public int ListCarById()
        {
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" Wprowadż Id Samochodu");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine(" <= WYBRANO");
            Console.WriteLine("_________________________________________________");

            if (number != null)
            {
                var entity = _itemService.Items.FirstOrDefault(p => p.Id == number);
                if (entity != null)
                {
                    string insuranceDate = entity.InsuranceData.ToString("dd/MM/yyyy");
                    string technicalDate = entity.TechnicalData.ToString("dd/MM/yyyy");
                    Console.WriteLine($"  {entity.Id}   =>  {entity.Name} , {entity.TypeId}, {entity.EngineCapacity}, {insuranceDate}, {technicalDate} ");
                    Console.WriteLine(" NACIŚNIJ DOWOLNY KLAWISZ");
                    Console.ReadKey();
                    return number;
                }
                else
                {
                    Console.WriteLine("Id poza zakresem! - NACIŚNIJ DOWOLNY KLAWISZ");
                    Console.ReadKey();
                    return -1; //błąd Id poza zakresem
                }
            }
            else Console.WriteLine("Znak nie jest cyfrą! - NACIŚNIJ DOWOLNY KLAWISZ"); //błąd znak nie jest cyfrą

            Console.ReadKey();
            //Console.Clear();
            return -2; //błąd znak nie jest cyfrą
        }

        public void RemoveCarById(int id)
        {
           var car = _itemService.GetItemById(id) ;
            _itemService.Items.Remove(car) ;
        }


        public int RemoveCarById()
        {
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" Wprowadż Id Samochodu do usunięcia");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine(" <= WYBRANO");
            Console.WriteLine("_________________________________________________");

            if (number != null)
            {
                var entity = _itemService.Items.FirstOrDefault(p => p.Id == number);
                if (entity != null)
                {
                    RemoveCarById(entity.Id);
                    Console.ReadKey();
                    return number;
                }
                else
                {
                    Console.WriteLine("Id poza zakresem! - NACIŚNIJ DOWOLNY KLAWISZ");
                    Console.ReadKey();
                    return -1; //błąd Id poza zakresem
                }
            }
            else Console.WriteLine("Znak nie jest cyfrą! - NACIŚNIJ DOWOLNY KLAWISZ"); //błąd znak nie jest cyfrą

            Console.ReadKey();
            //Console.Clear();
            return -2; //błąd znak nie jest cyfrą  

        }

        public Car GetItemById(int id)
        {
            var item = _itemService.GetItemById(id);
            return item;
        }


    }
}
