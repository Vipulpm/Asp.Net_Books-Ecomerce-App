using BookHub.DataAccess.Repository.IRepository;
using BookHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Remove(CoverType obj);
        void Update(CoverType obj);
    
    }
}
