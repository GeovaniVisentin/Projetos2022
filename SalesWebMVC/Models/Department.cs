using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Sellers> Seller { get; set; } = new List<Sellers>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSeler(Sellers seller)
        {
            Seller.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Seller.Sum(seller => seller.TotalSales(initial, final));
            
        }



        public static implicit operator List<object>(Department v)
        {
            throw new NotImplementedException();
        }
       
    }
}
