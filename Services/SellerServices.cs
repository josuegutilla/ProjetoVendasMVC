using VendasWebMvc.Data;
using VendasWebMvc.Models;

namespace VendasWebMvc.Services
{
    public class SellerServices
    {
        private readonly VendasWebMvcContext _context;

        public SellerServices(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }
    }
}
