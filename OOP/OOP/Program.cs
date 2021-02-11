using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Bangun
    {
        public virtual void bangunDatar()
        {
            Console.WriteLine("Ini Rumus Bangun Datar");
        }
        public virtual void bangunRuang()
        {
            Console.WriteLine("Ini Rumus Bangun Ruang");
        }
        private int panjang, lebar, sisi, alas, tinggi;
        public int Panjang
        {
            get { return panjang; }
            set { panjang = value; }
        }
        public int Lebar
        {
            get { return lebar; }
            set { lebar = value; }
        }
        public int Sisi
        {
            get { return sisi; }
            set { sisi = value; }
        }
        public int Alas
        {
            get { return alas; }
            set { alas = value; }
        }
        public int Tinggi
        {
            get { return tinggi; }
            set { tinggi = value; }
        }
    }
    class BangunDatar : Bangun
    {

        public override void bangunDatar()
        {
            Console.WriteLine("==== INI PROGRAM MENGHITUNG BANGUN DATAR =====");
        }
        private int luas;
        public double luasDouble;
        public int Luas
        {
            get { return luas; }
            set { luas = value; }
        }

        public int persegipanjang()
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Ini Persegi Panjang");
            Console.Write("Masukkan Nilai Panjangnya : ");
            Panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai Lebarnya : ");
            Lebar = Convert.ToInt32(Console.ReadLine());
            Luas = Panjang * Lebar;
            Console.WriteLine("Luas nya = " + Luas);
            return Luas;
        }

        public int persegi()
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Ini Persegi");
            Console.Write("Masukkan Nilai Sisinya : ");
            Sisi = Convert.ToInt32(Console.ReadLine());
            Luas = Sisi * Sisi;
            Console.WriteLine("Luas nya = " + Luas);
            return Luas;
        }
        public int jajarGenjang()
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Ini Jajar Genjang");
            Console.Write("Masukkan Nilai Alasnya : ");
            Alas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai Tinggginya : ");
            Tinggi = Convert.ToInt32(Console.ReadLine());
            Luas = (Alas * Tinggi);
            Console.WriteLine("Luas nya = " + Luas);
            return  Luas;
        }

    }
    class BangunRuang : Bangun
    {
        protected int volume;
        
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public override void bangunRuang()
        {
            Console.WriteLine("==== INI PROGRAM MENGHITUNG BANGUN RUANG =====");
        }
        public int Kubus()
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Ini Kubus");
            Console.Write("Masukkan Nilai Sisinya : ");
            Sisi = Convert.ToInt32(Console.ReadLine());
            
            Volume = Sisi * Sisi * Sisi;
            Console.WriteLine("Luas nya = " + Volume);
            return Volume;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int pilih1;
            string ulang;
            BangunDatar Bangun1 = new BangunDatar();
            BangunRuang Bangun2 = new BangunRuang();
            Bangun1.Panjang = 10;
            Bangun1.Lebar = 5;
            Bangun1.Sisi = 5;
            Bangun2.Sisi = 10;
            try
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("=========================");
                    Console.WriteLine("1.Bangun Datar");
                    Console.WriteLine("2.Bangun Ruang");
                    Console.Write("Silahkan Masukkan Pilihan Anda : ");
                    pilih1 = Convert.ToInt32(Console.ReadLine());

                    switch (pilih1)
                    {
                        case 1:
                            Console.WriteLine();
                            Bangun1.bangunDatar();
                            Console.WriteLine("===============================");
                            Console.WriteLine("1.Persegi Panjang");
                            Console.WriteLine("2.Persegi");
                            Console.WriteLine("3.Jajar Genjang");
                            Console.Write("Silahkan Masukkan Pilihan Anda : ");
                            pilih1 = Convert.ToInt32(Console.ReadLine());
                            switch (pilih1)
                            {
                                case 1:
                                    Bangun1.persegipanjang();
                                    break;
                                case 2:
                                    Bangun1.persegi();
                                    break; 
                                case 3:
                                    Bangun1.jajarGenjang();
                                    break;
                                default:
                                    Console.WriteLine("Tidak ada pilihan");
                                    break;
                            }
                            break;
                        case 2:
                            Bangun2.bangunRuang();
                            Console.WriteLine("===============================");
                            Console.WriteLine("1.Kubus");
                            Console.WriteLine("2.Coming Sonn");
                            Console.Write("Silahkan Masukkan Pilihan Anda : ");
                            pilih1 = Convert.ToInt32(Console.ReadLine());
                            switch (pilih1)
                            {
                                case 1:
                                    Bangun2.Kubus();
                                    break;
                                case 2:
                                    Console.WriteLine("COMING SOON!!!");
                                    break;
                                default:
                                    Console.WriteLine("Tidak ada pilihan");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Tidak ada pilihan");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Apakah Anda Ingin Mengulang ?");
                    Console.Write("(ya/tidak) = ");
                    ulang = Console.ReadLine();
                    Console.WriteLine();
                } while (ulang == "ya");
                Console.WriteLine("Keluar");
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Console.WriteLine("Tolong Masukkan Angka!!!");
                throw;
            }
            Console.ReadLine();
        }
    }
}
