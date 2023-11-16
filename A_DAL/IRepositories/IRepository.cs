using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IRepository
    {
        List<Qlh> GetAll();
        void Delete(Qlh qld);
        Qlh Insert(Qlh qlh);
        void Update(Qlh qlh);
        Qlh GetByID(int id);
    }
}
