using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar_KPL
{
    class AutomataDashboard
    {
        
        public enum State { LOGIN, DASHBOARD, MEMINJAMBUKU, DATABUKU, DATAPENGGUNA, PENGEMBALIAN, LOGOUT }; //Atribut State
        public static State posisi, nextPosisi;

        public AutomataDashboard() { }

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

                else if (nextPos == State.DATAPENGGUNA) //Kemudian jika posisi state selanjutnya = DATAPENGGUNA
                {
                    Data_Pengguna dataPengguna = new Data_Pengguna();
                    dataPengguna.Show(); // maka show form Data Pengguna
                }
                else if (nextPos == State.DATABUKU) //Kemudian jika posisi state selanjutnya = DATABUKU
                {
                    DataBuku dataBuku = new DataBuku();
                    dataBuku.Show(); // maka show form Data Buku
                }
                else if (nextPos == State.PENGEMBALIAN) //Kemudian jika posisi state selanjutnya = PENGEMBALIAN
                {
                    PengembalianBuku pengembalianBuku = new PengembalianBuku();
                    pengembalianBuku.Show(); // maka show form Pengembalian buku
                }
                else if (nextPos == State.LOGOUT) //Kemudian jika posisi state selanjutnya = LOGOUT
                {
                    Login logout = new Login();
                    logout.Show(); // maka show form Login

                }
            }
        

            else if ( State.MEMINJAMBUKU == posisi  || State.LOGIN == posisi ||  State.DATAPENGGUNA == posisi ||  State.DATABUKU == posisi  ||  State.LOGOUT == posisi  ||  State.PENGEMBALIAN == posisi ) // Keadaan mengembalikan ke menu Dashboard
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