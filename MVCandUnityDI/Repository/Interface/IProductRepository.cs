using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCandUnityDI.Repository.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetID(int Id);
        Product Add(Product item);
        bool Update(Product item);
        bool Delete(int Id);

    }
}
