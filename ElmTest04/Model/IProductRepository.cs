using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IProductRepository
    {
        IList<Product> FindAll();
        Product FindByID(int id);
        IList<Product> FindAllByType(ProductType productName);
    }
}
