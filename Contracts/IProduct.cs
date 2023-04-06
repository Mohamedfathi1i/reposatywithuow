using PremiumMainCS.GenericResponse;
using reposatywithuow.Entities.Models;

namespace reposatywithuow.Contracts
{
    public interface IProduct
    {
        GenericResponse<List<Product>> GetAllProduct();
    }
}
