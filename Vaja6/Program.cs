using System.IO;

namespace vaja6 {

  // Enumerator za tip poklica
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

        public Igralec() { //Privzeti konstruktor
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id { //Metoda ki vrača id (celo število)
            get
            {
                return id;
            }
        }

        public string U_ime { //Bralno - pisna lasnost za ime
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        public string U_geslo //Bralno - pisna lasnost za geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        public static int StIg //Samo bralna lasnost za stig
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
