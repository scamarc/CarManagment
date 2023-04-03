using CarManagment.Domain.Common;
using CarManagment.App.Abstract;
using CarManagment.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagment.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }

        public BaseService()
        {
            Items = new List<T>();
        }

        public int GetLastId()
        {
            int lastId;
            if (Items.Any())
            {
                lastId = Items.OrderBy(p => p.Id).LastOrDefault().Id;
            }
            else
            {
                lastId = 0;
            }
            return lastId;
        }
        public int AddItem(T item)
        {
            Items.Add(item);
            return item.Id;
        }

        public void RemoveItem(T item)
        {
            Items.Remove(item);
        }

        public List<T> GetAllItems()
        {
            return Items;
        }

        public int UpdateItem(T item)
        {
            var entity = Items.FirstOrDefault(p => p.Id == item.Id);
            if (entity != null)
            {
                entity = item;
            }
            return item.Id;
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

        public T GetItemById(int id)
        {
            var entity = Items.FirstOrDefault(p => p.Id == id);
            return entity;
        }
    }
}

