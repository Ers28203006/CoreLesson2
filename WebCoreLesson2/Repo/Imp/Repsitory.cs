using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreLesson2.Models;

namespace WebCoreLesson2.Repo.Imp
{
    public class Repsitory : IRepository
    {
        private readonly StudentContext db;
        public Repsitory(StudentContext context)
        {
            db = context;
        }
        public void Create(Student item)
        {
            db.Add(item);
            db.SaveChanges();
        }

        public void Delete(Student item)
        {
            db.Remove(item);
            db.SaveChanges();

        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Edit(Student item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Student GetEntity(int id)
        {
            return db.Students.Find(id);
        }

        public IEnumerable<Student> GetEntitysList()
        {
            return db.Students.ToList();
        }
    }
}
