using DataLayer.Repositories.Unit_Of_Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    // This class is reponsible for encapsulating all the objects of services classes.
    
    public class BaseService
    {
        public IUnitOfWork UnitOfWork { get; }
        // Constructor of base service
        public BaseService(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
    }
}
