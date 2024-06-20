using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories
{
    public class BrandRepository: BaseRepository<Brand>
    {
        BusinessAutomationDbContext db;
        public BrandRepository(BusinessAutomationDbContext db):base(db)
        {
            this.db = db;
          
        }

        public BusinessAutomationDbContext Db
        {
            get
            {
                return db;
            }
            set
            {
                db = value;
            }
        }

        public Brand GetById(int id)
        {
            var existingBrand = db.Brands.FirstOrDefault(c => c.Id == id);

            return existingBrand;
        }

      
    
    
    }
}
