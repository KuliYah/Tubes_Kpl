using System;
using System.Collections.Generic;

namespace TugasBesar_KPL
{
    class Admin
    {
        public string libraryId;
        public string password;

        public Admin() {}

        public Admin(string libraryId,string password)
        {
            try
            {
                this.libraryId = libraryId;
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
