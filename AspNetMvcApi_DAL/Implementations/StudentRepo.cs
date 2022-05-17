using AspNetMvcApi_DAL.Contracts;
using AspNetMvcApi_EL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcApi_DAL.Implementations
{
    public class StudentRepo : RepositoryBase<Student, int>, IStudentRepo
    {
        public StudentRepo(MyContext myContext):base(myContext)
        {

        }
    }
}
