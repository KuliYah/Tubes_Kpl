using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar_KPL
{
    class TableDrivenAdmin
    {
        public enum LibraryId { admin, admin2 };
        
        public static string[] Password = { "admin", "admin2" };

        public static string getAdmin(LibraryId libid)
        {
            return Password[(int)libid];
        }

    }
}
