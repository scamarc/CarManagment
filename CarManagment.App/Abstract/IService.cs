using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagment.App.Abstract
{
    public interface IService<T>
    {
        List<T> Items { get; set; }

        List<T> GetAllItems();
        T GetItemById(int id);
        int GetLastId();
        int AddItem(T item);
        int UpdateItem(T item);
        void RemoveItem(T item);
        //void View();
        //void View(int id);
    }
}
