using IceCreamParlorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamParlorApi.Data
{
    public interface IParlorRepo
    {
        IEnumerable<IceCream> GetAllItems();
        //T GetItemById<T>(int id);
        //void CreateItem<T>(T item);
        //void UpdateItem<T>(T item);
        //void DeleteItem<T>(T item);
    }
}
