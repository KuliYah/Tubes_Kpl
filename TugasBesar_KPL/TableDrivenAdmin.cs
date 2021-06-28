using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar_KPL
{
    class TableDrivenAdmin
    {
        public enum LibraryId { admin, admin2 }; //atribut LibraryId
        
        public static string[] Password = { "admin", "admin2" }; // atribut Password

        public static string getAdmin(LibraryId libid) // method getter
        {
            return Password[(int)libid]; // return pasword dan libid
        }

    }
}
