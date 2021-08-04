using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

        //public void Add(Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Product> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Add(Product product)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        context.Products.Add(product);
        //        context.SaveChanges();
        //    }
        //}

        //public void Update(Product product)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        // context.Products.Add(product);
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Product product)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        context.Products.Add(product);
        //        context.SaveChanges();
        //    }
        //}

        //public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        return context.Products.ToList(filter);
        //    }
        //}

        //public Product Get(Expression<Func<Product, bool>> filter)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        return context.Products.SingleOrDefault(filter);
        //    }
        //}
    }
}
