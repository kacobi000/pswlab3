using System;

namespace HelloWorld
{
    public class Student
    {

        private int nr_indeksu;
        private String imie;
        private String nazwisko;
        private int rok_st;
        public Student(int nr_indeksu, String imie, String nazwisko, int rok_st)
        {
            this.nr_indeksu = nr_indeksu;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok_st = rok_st;
        }

        public int getNrIndeksu()
        {
            return nr_indeksu;
        }

        public int setNrIndeksu(int nr_indeksu)
        {
            this.nr_indeksu = nr_indeksu;
            return 0;
        }

        public String getImie()
        {
            return imie;
        }

        public int setImie(String imie)
        {
            this.imie = imie;
            return 0;
        }

        public String getNazwisko()
        {
            return nazwisko;
        }

        public int setNazwisko(String nazwisko)
        {
            this.nazwisko = nazwisko;
            return 0;
        }
        public int getRokSt()
        {
            return rok_st;
        }

        public int setRokSt(int rok_st)
        {
            this.rok_st = rok_st;
            return 0;
        }
        public String toString()
        {
            return "\nStudent:" + "\nIndex: " + nr_indeksu + "\nImie: " + imie + "\nNazwisko: " + nazwisko + "\nRok: " + rok_st + "\n";
        }


    }

     public class Uni
    {

        public double[] ListaDopuszczalnychOcen = { 2, 2.5, 3, 3.5, 4, 4.5, 5, 5.5 };
        public List<Student> ListaStudentow = new List<Student>();
        public List<List<double>> ocenyStudentow = new List<List<double>>();
        private int nr_indeksu = 0;
        public void dodajStudenta(String imie, String nazwisko, int rok_st)
        {
            ListaStudentow.Add(new Student(nr_indeksu, imie, nazwisko, rok_st));

            Console.WriteLine("Wpisz ile ocen chcesz wstawić temu studentowi: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<double> oceny = new List<double>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Wpisz ocenę: ");
                double value = Convert.ToDouble(Console.ReadLine());
                oceny.Add(value);
            }
            ocenyStudentow.Add(oceny);
            nr_indeksu++;
        }

        public void usunStudenta(int index)
        {
            for (int i = 0; i < ListaStudentow.Count; i++)
            {
                int indexValue = ListaStudentow[i].getNrIndeksu();
                if (index == indexValue)
                {
                    ListaStudentow.RemoveAt(i);
                    ocenyStudentow.RemoveAt(i);
                }
            }
        }

        public void obliczSredniaAll()
        {
            double avg = 0;
            int counter = 0;

            for (int i = 0; i < ocenyStudentow.Count; i++)
            {
                for (int j = 0; j < ocenyStudentow[i].Count; j++)
                {
                    avg += ocenyStudentow[i][j];
                    counter++;
                }
            }
            avg = avg / counter;
            Console.WriteLine("\nŚrednia wszystkich studentów: " + avg);
        }

        public void obliczSrednia(int index)
        {
            double avg = 0;
            for (int i = 0; i < ListaStudentow.Count; i++)
            {
                int indexVal = ListaStudentow[i].getNrIndeksu();
                if (index == indexVal)
                {
                    for (int j = 0; j < ocenyStudentow[i].Count; j++)
                    {
                        avg += ocenyStudentow[i][j];
                    }
                    avg = avg / ocenyStudentow[i].Count;
                    Console.WriteLine("\nŚrednia studenta " + ListaStudentow[i].getImie() + " " + ListaStudentow[i].getNazwisko() + " to: " + avg);
                }
            }
        }

        public void showAll()
        {
            for (int i = 0; i < ListaStudentow.Count; i++)
            {
                Console.Write(ListaStudentow[i].toString() + "\nOceny: ");
                for (int j = 0; j < ocenyStudentow[i].Count; j++)
                {
                    Console.Write(ocenyStudentow[i][j] + ", ");
                }
                Console.Write("\n");
            }
        }
    }
}

