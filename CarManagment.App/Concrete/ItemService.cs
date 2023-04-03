using CarManagment.Domain.Entity;
using CarManagment.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarManagment.App.Concrete
{
    public class ItemService : BaseService<Car>
    {
        public ItemService()
        {
            Initialize();
        }

        //public List<Car> GetItemByTypeId(int typeId)
        //{
        //    List<Car> result = new List<Car>();
        //    foreach (var car in Items)
        //    {
        //        if (car.TypeId == typeId)
        //        {
        //            result.Add(car);
        //        }
        //    }
        //    return result;
        //}

        private void Initialize()
        {
            AddItem(new Car(1, "DW777FU", 1, 1980, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24)));
            AddItem(new Car(2, "DW7778AG", 1, 1200, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24)));
            AddItem(new Car(3, "DW7779WR", 2, 1400, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24)));
            AddItem(new Car(4, "DW7780WR", 3, 1200, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24)));
            AddItem(new Car(5, "DW767FU", 1, 1980, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24)));
            AddItem(new Car(6, "DW7768AG", 1, 1980, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24)));
            AddItem(new Car(7, "DW7769WR", 2, 1400, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24)));
            AddItem(new Car(8, "DW7760WR", 3, 1400, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24)));
        }
        //public void View()
        //{
        //    Console.WriteLine("____________________________________");
        //    Console.WriteLine("|                                  |");
        //    Console.WriteLine("|  L I S T A  S A M O C H O D Ó W  |");
        //    Console.WriteLine("|__________________________________|");
        //    Console.WriteLine("|                                  |");
        //    foreach (var car in Items)
        //    {
        //        //string insuranceDate = car.InsuranceData.ToString("dd/MM/yyyy");
        //        //string technicalDate = car.TechnicalData.ToString("dd/MM/yyyy");
        //        //Console.WriteLine($"  {car.Id}   =>  {car.Name} , {car.EngineCapacity}, {insuranceDate}, {technicalDate} ");
        //        Console.WriteLine($"  {car.Id}   =>  {car.Name}   ");
        //    }
        //    Console.WriteLine("|__________________________________|");
        //}

        //public void View(int typId)
        //{
        //    //CarType carType = typId; 
        //    Console.WriteLine("____________________________________");
        //    Console.WriteLine("|                                  |");
        //    Console.WriteLine("|  L I S T A  S A M O C H O D Ó W  |");
        //    Console.WriteLine("|__________________________________|");
        //    Console.WriteLine($" Samochody typId = {typId}         ");
        //    foreach (var car in Items)
        //    {
        //        if (car.TypeId == typId)
        //        {
        //            Console.WriteLine($"{car.Id} => {car.Name}");
        //        }
        //    }

        //}

        //public void ItemsByTypeIdView(int typeId)
        //{
        //    List<Item> toShow = new List<Item>();
        //    foreach (var item in Items) 
        //    {
        //    if (item.TypeId == typeId)
        //        {
        //            toShow.Add(item);
        //        }
        //    }
        //    Console.WriteLine(toShow.ToStringTable(new[] { "Id", "Name" }, async => async.Id, async +> async.Name));
        //}

        //public int ItemTypeSelectionView()
        //{
        //    Console.WriteLine(" Wprowadź Typ Id dla typu obiektu :");
        //    var ItemId = Console.ReadKey();
        //    int id;
        //    Int32.TryParse(ItemId.KeyChar.ToString(), out id);
        //    return id;
        //}

        //public void ItemDetailView(int detailId)
        //{
        //    Item productToShow = new Item(1, "");
        //    foreach (var item in Items)
        //    {
        //        if ( item.Id == detailId)
        //        {
        //            productToShow = item;
        //            break
        //        }
        //    }
        //    Console.WriteLine($"Item id: {productToShow.Id}");
        //    Console.WriteLine($"Item name: {productToShow.Name}");
        //    Console.WriteLine($"Item type id: {productToShow.TypeId}");
        //}

        //public int ItemDetailSelectionView()
        //{
        //    Console.WriteLine("Wprowadź id dla obiektu:");
        //    var ItemId = Console.ReadKey();
        //    int id;
        //    Int32.TryParse(ItemId.KeyChar.ToString(),out id);
        //    return id;
        //}
    }
}
