using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.EF;
namespace ModelEF.DAO
{
    public class CategoryDAO
    {
        //CRUD

        private BookStoreDbContext db;

        public CategoryDAO()
        {
            db = new BookStoreDbContext();
        }

        public IEnumerable<Category> getAll()
        {
            return db.Category.ToList();
        }
    }
}
