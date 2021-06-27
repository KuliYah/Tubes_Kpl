using System;
using System.Collections.Generic;

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
            try
            {
                this.libraryId = libraryId;
                this.nama = nama;
                this.email = email;
                this.noHP = noHP;
                this.password = password;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void setLibId(String libraryId)
        {
            this.libraryId = libraryId;
        }
        public String getLibId()
        {
            return this.libraryId;
        }
        public void setNama(String nama)
        {
            this.nama = nama;
        }
        public String getNama()
        {
            return this.nama;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return this.email;
        }
        public void setNoHP(String noHP)
        {
            this.noHP = noHP;
        }
        public String getNoHP()
        {
            return this.noHP;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public String getPassword()
        {
            return this.password;
        }

    }
}
