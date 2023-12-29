using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IRepository<T>
    {
        void Save(T entity);
        IList<T> GetAll();
        T Get(int id);

        //IList<T> SearchByName(string name);

    }

    public interface ISearcher<T>
    {
        IList<T> SearchByName(string name);
    }

    public class Order
    {

    }

    public class OrderRepository : IRepository<Order>
    {
        public Order Get(int id)
        {
            return new Order();
        }

        public IList<Order> GetAll()
        {
            return new List<Order>();
        }

        public void Save(Order entity)
        {

        }

        //public IList<Order> SearchByName(string name)
        //{
        //    //Siparişler ada göre aranamayacağı için yazmadık :)
        //    throw new NotImplementedException();
        //}
    }

    public class Product
    {

    }

    public class ProductRepository : IRepository<Product>, ISearcher<Product>
    {
        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Product entity)
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
