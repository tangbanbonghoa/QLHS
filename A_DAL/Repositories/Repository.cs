using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepositories;
using A_DAL.Models;

namespace A_DAL.Repositories
{
    public class Repository : IRepository
    {
        public List<Qlh> GetAll()
        {
            using (QlhsContext db = new QlhsContext())
            {
                return db.Qlhs.ToList();
            }
        }
        public Qlh Insert (Qlh qlh)
        {
            using (QlhsContext db = new QlhsContext())
            {
                db.Qlhs.Add(qlh);
                db.SaveChanges();
                return qlh;
            }
        }
        public void Update(Qlh qlh)
        {
            using (QlhsContext db = new QlhsContext())
            {
                db.Qlhs.Update(qlh);
                db.SaveChanges();
            }
        }
        public void Delete(Qlh qlh)
        {
            using (QlhsContext db = new QlhsContext())
            {
                db.Qlhs.Attach(qlh);
                db.Qlhs.Remove(qlh);
                db.SaveChanges() ;
            }
        }
        public Qlh GetByID(int id)
        {
            using (QlhsContext db = new QlhsContext())
            {
                var spFound = db.Qlhs.FirstOrDefault(Qlh => Qlh.Id == id);
                return spFound;
            }
        }
    }
}
