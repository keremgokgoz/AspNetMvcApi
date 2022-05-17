﻿using AspNetMvcApi_EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcApi_BLL.ContractBLL
{
    public interface IStudentService
    {
        ResponseData GetAllStudents();
        ResponseData AddStudent(StudentVM student);
        ResponseData UpdateStudent(int studentId,string newName,string newSurname);
        ResponseData DeleteStudent(int studentId);
    }
}
