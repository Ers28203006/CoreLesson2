using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreLesson2.Models;

namespace WebCoreLesson2.Repo
{
    public interface IRepository
    {
        void Create(Student item);
        Student GetEntity(int id);
        IEnumerable<Student> GetEntitysList();
        void Delete(Student item);
        void Edit(Student item);
    }
}
