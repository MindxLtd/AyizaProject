using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Unit_Of_Work
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}
