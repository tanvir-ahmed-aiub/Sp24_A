using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID>
    {
        void Create(CLASS obj);
        List<CLASS> Get();
        CLASS Get(ID id);
        void Update(CLASS obj);
        void Delete(ID id);
    }
}
