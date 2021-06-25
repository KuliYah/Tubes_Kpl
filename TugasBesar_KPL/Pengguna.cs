using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar_KPL
{
    class Pengguna
    {
        public string libraryId;
        public string nama;
        public string email;
        public string noHP;
        public string password;

        public Pengguna() {}

        public Pengguna(string libraryId, string nama, string email, string noHP, string password)
        {
            this.libraryId = libraryId;
            this.nama = nama;
            this.email = email;
            this.noHP = noHP;
            this.password = password;
        }
    }
}
