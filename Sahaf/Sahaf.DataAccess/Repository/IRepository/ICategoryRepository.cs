using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sahaf.Models;

namespace Sahaf.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>

    {
        void Update(Category obj);
    }
}
