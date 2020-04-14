using System;

class Karyawan{
	public string NIK { get; set;}
	public string Nama { get; set;}
	public int Gaji {get; set;}
	public int GajiNaik {get; set;}


	public Karyawan(string newNIK, string newNama, int newGajiBulanan){
		NIK = newNIK;
		Nama = newNama;
		Gaji = newGajiBulanan;

		if ( newGajiBulanan < 0){
			Gaji = 0;
		}
	}

	public void getNewGaji(){
		int TambahanGaji = Gaji/ GajiNaik;
        Gaji = Gaji + TambahanGaji;
        Console.WriteLine("{0}  \t{1}\t\t\t {2}", NIK, Nama, Gaji);
	}

	public void PrintAndShow(){
		Console.WriteLine("{0}  \t{1}\t\t\t {2}", NIK, Nama, Gaji);
	}

	public class MainProgram{
		static void Main(String[] args){
			Console.WriteLine("No  NIK\t\t Nama \t\t\t Gaji");
			Console.WriteLine("-------------------------------------------------");
			Karyawan karyawan1 = new Karyawan("1. 1920002045", "Aji", 3000000);
			Karyawan karyawan2 = new Karyawan("2. 1924022855", "Saka", 2500000);

			karyawan1.PrintAndShow();
			karyawan2.PrintAndShow();

			Console.WriteLine("\n\n Yaaaayyy dapat kenaikan gaji 10% !!");
			Console.WriteLine("\n\nNo  NIK\t\t Nama \t\t\t Gaji");
			Console.WriteLine("-------------------------------------------------");
			
            karyawan1.GajiNaik = 10;
            karyawan1.getNewGaji();

            karyawan2.GajiNaik = 10;
            karyawan2.getNewGaji();

			Console.ReadKey();
		}
	}
}