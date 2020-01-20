using DatabaseFramework;
using LT.IMF.Data.DataContext;
using LTI.IMF.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT.IMF.Data.UnitOfWork
{
    public class IMFUnitOfWork : UnitOfWork<IIMFDataContext>
    {
        public IMFUnitOfWork()
            : base(new IMFDataContext())
        {

        }
    }
}
