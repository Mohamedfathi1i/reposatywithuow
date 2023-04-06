using PremiumMainCS.GenericResponse;
using reposatywithuow.Contracts;
using reposatywithuow.Entities.Context;
using reposatywithuow.Entities.Models;

namespace reposatywithuow.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationContext _context;

        public ProductRepository(ApplicationContext context)
        {
            _context = context;

        }
        public GenericResponse<List<Product>> GetAllProduct()
        {
            List<Product> allProducts = _context.products.ToList();
            return new GenericResponse<List<Product>>()
            {
                ResponseTextArabic = "تم استرجاع البيانات بنجاح ",
                ResponseText = "Data Retrived successfully",
                ResponseObject = allProducts,
                ResponseCode = 200,
                Status = EnumStatus.Success
            };

        }
    }
}
