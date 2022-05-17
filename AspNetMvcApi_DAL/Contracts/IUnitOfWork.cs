using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcApi_DAL.Contracts
{
    public interface IUnitOfWork
    {
        IStudentRepo StudentRepo { get; }
    }
}
