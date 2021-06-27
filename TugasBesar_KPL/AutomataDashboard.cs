using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar_KPL
{
    class Automata
    {
        public enum State { LOGIN, DASHBOARD, MEMINJAMBUKU, LOGOUT }; //Atribut State
        public static State posisi, nextPosisi;

        public Automata() { }

        public static void setPosisi(State pos, State nextPos) //Setter keadaan posisi automata
        {
            posisi = pos;
            nextPosisi = nextPos;
        }

        public static State getPosisi() //Getter Posisi
        {
            return posisi;
        }

        public static void posisiTransition(State nextPos)
        {
            if (posisi == State.LOGIN) //Jika keadaan = LOGIN
            {
                if (nextPos == State.DASHBOARD) // Jika keadaan Posisi state selanjutnya = DASHBOARD
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            else if (posisi == State.DASHBOARD) //Kemudian jika posisi state selanjutnya = DASHBOARD
            {
                if (nextPos == State.MEMINJAMBUKU) //Setelahnya jika posisi state selanjutnya = MEMINJAMBUKU
                {
                    MeminjamBuku meminjam = new MeminjamBuku();
                    meminjam.Show(); // maka show form MeminjamBuku
                }
                
                else if (nextPos == State.LOGOUT) //Kemudian jika posisi state selanjutnya = LOGOUT
                {
                    Login logout = new Login();
                    logout.Show(); // maka show form Login

                }


                else if (State.MEMINJAMBUKU == posisi || State.LOGOUT == posisi) // Keadaan mengembalikan ke menu Dashboard
                {
                    if (nextPos == State.DASHBOARD)
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                }
            }

        }
    }
}
