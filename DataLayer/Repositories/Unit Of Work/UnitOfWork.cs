using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Unit_Of_Work
{
    public class UnitOfWork:Disposable, IUnitOfWork
    {
        int IUnitOfWork.Commit()
        {
            return 0;
        }

        protected override void DisposeCore()
        {
            
        }
    }
}
