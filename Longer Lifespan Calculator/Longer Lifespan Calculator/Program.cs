using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

internal class Program
{
    private static void hitungRekomendasi(double AMR, double berat)
    {
        bool selesai = false;
        while (selesai == false)
        {
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("|       LONGER LIFESPAN       |");
            Console.WriteLine("| by : Feylin, Michelle, Ruby |");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine();
            Console.WriteLine("Rekomendasi Nutrisi Harian : ");

            double karbohidrat1 = (AMR * 0.60) / 4;
            double karbohidrat2 = (AMR * 0.75) / 4;
            double karbohidrat = (karbohidrat1 + karbohidrat2) / 2;
            double protein1 = (AMR * 0.10) / 4;
            double protein2 = (AMR * 0.15) / 4;
            double protein = (protein1 + protein2) / 2;
            double serat = (AMR / 1000) * 14;
            double lemak = (AMR * 0.20) / 9;
            double air = berat * 30;

            Console.WriteLine("[1] Karbohidrat = " + Math.Round(karbohidrat1) + "-" + Math.Round(karbohidrat2) + " gram");
            Console.WriteLine("[2] Protein = " + Math.Round(protein1) + "-" + Math.Round(protein2) + " gram");
            Console.WriteLine("[3] Serat = " + Math.Round(serat) + " gram");
            Console.WriteLine("[4] Lemak = " + Math.Round(lemak) + " gram");
            Console.WriteLine("[5] Air = " + Math.Round(air) + " mL");
            Console.Write("Rekomendasi makanan apa yang ingin kamu lihat : ");
            Console.WriteLine();
            int rekomen = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (rekomen)
            {
                case 1:
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|       LONGER LIFESPAN       |");
                    Console.WriteLine("| by : Feylin, Michelle, Ruby |");
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine();
                    List<string> listKarbs = new List<string>();
                    listKarbs.Add($"1 mangkok Nasi Putih mengandung 29,3 gram karbohidrat");
                    listKarbs.Add($"1 lembar Roti Tawar Putih mengandung 18,5 gram karbohidrat");
                    listKarbs.Add($"1 mangkok Mie mengandung 40,02 gram karbohidrat");
                    listKarbs.Add($"1 mangkok Oatmeal mengandung 25,37 gram karbohidrat");
                    for (int i = 0; i < listKarbs.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + listKarbs[i]);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|       LONGER LIFESPAN       |");
                    Console.WriteLine("| by : Feylin, Michelle, Ruby |");
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine();
                    List<string> listProtein = new List<string>();
                    double ayam = (protein / 25.01) * 100;
                    double sapi = (protein / 26.33) * 100;
                    listProtein.Add($"{Math.Round(ayam)} gram Daging Ayam");
                    listProtein.Add($"{Math.Round(sapi)} gram Daging Sapi");
                    listProtein.Add($"Telur mengandung 6,29 gram protein");
                    listProtein.Add($"1 gelas Susu mengandung 10,2 gram protein");
                    for (int i = 0; i < listProtein.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + listProtein[i]);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|       LONGER LIFESPAN       |");
                    Console.WriteLine("| by : Feylin, Michelle, Ruby |");
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine();
                    List<string> listSerat = new List<string>();
                    double kangkung = (serat / 1.9) * 100 / 1000;
                    double bayam = (serat / 2.2) * 100 / 1000;
                    double selada = (serat / 1.2) * 100 / 1000;
                    double wortel = (serat / 2.8) * 100 / 1000;
                    listSerat.Add($"{Math.Round(kangkung)} kg Kangkung");
                    listSerat.Add($"{Math.Round(bayam)} kg Bayam");
                    listSerat.Add($"{Math.Round(selada)} kg Selada");
                    listSerat.Add($"{Math.Round(wortel)} kg Wortel");
                    for (int i = 0; i < listSerat.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + listSerat[i]);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|       LONGER LIFESPAN       |");
                    Console.WriteLine("| by : Feylin, Michelle, Ruby |");
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine();
                    List<string> listLemak = new List<string>();
                    double kacang = (lemak / 56.33) * 100;
                    double alpukat = (lemak / 14.66) * 100;
                    double mentega = (lemak / 11.52);
                    double keju = (lemak / 33.14) * 100;
                    listLemak.Add($"{Math.Round(kacang)} gram Kacang-kacangan");
                    listLemak.Add($"{Math.Round(alpukat)} gram Alpukat");
                    listLemak.Add($"{Math.Round(mentega)} sdm Mentega");
                    listLemak.Add($"{Math.Round(keju)} gram Keju");
                    for (int i = 0; i < listLemak.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + listLemak[i]);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|       LONGER LIFESPAN       |");
                    Console.WriteLine("| by : Feylin, Michelle, Ruby |");
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine();
                    double gelas = Math.Round(air / 300);
                    string glassSymbol1 = "|-|";
                    string glassSymbol2 = "| |";
                    string glassSymbol3 = "|_|";
                    Console.WriteLine($"Banyak air yang harus kamu minum adalah {gelas} gelas");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = 0; i < gelas; i++)
                    {
                        Console.Write(glassSymbol1);
                        Console.Write(" ");
                    }

                    Console.WriteLine();

                    for (int i = 0; i < gelas; i++)
                    {
                        Console.Write(glassSymbol2);
                        Console.Write(" ");
                    }

                    Console.WriteLine();

                    for (int i = 0; i < gelas; i++)
                    {
                        Console.Write(glassSymbol3);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|       LONGER LIFESPAN       |");
                    Console.WriteLine("| by : Feylin, Michelle, Ruby |");
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine();
                    Console.WriteLine("Menu yang dipilih tidak ada. Program akan berhenti.");
                    selesai = true;
                    break;
            }
        }
    }
    private static void Perempuan(string gender, double berat, double tinggiCm, int usia, int aktif, double AMR)
    {

        double BMR = 655.1 + (9.563 * berat) + (1.850 * tinggiCm) - (4.676 * usia);

        if (aktif == 1)
        {
            AMR = BMR * 1.2;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }
        else if (aktif == 2)
        {
            AMR = BMR * 1.375;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }
        else if (aktif == 3)
        {
            AMR = BMR * 1.55;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }
        else if (aktif == 4)
        {
            AMR = BMR * 1.725;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }
        else if (aktif == 5)
        {
            AMR = BMR * 1.9;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }

        Console.ReadKey();
        Console.Clear();
        hitungRekomendasi(AMR, berat);
    }

    private static void LakiLaki(string gender, double berat, double tinggiCm, int usia, int aktif, double AMR)
    {
        double BMR = 66.5 + (13.75 * berat) + (5.003 * tinggiCm) - (6.75 * usia);

        if (aktif == 1)
        {
            AMR = BMR * 1.2;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }
        else if (aktif == 2)
        {
            AMR = BMR * 1.375;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }
        else if (aktif == 3)
        {
            AMR = BMR * 1.55;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }
        else if (aktif == 4)
        {
            AMR = BMR * 1.725;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }
        else if (aktif == 5)
        {
            AMR = BMR * 1.9;
            Console.WriteLine($"Kebutuhan kalori (AMR): {Math.Round(AMR)} kalori per hari");
        }

        Console.ReadKey();
        Console.Clear();
        hitungRekomendasi(AMR, berat);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("+-----------------------------+");
        Console.WriteLine("|       LONGER LIFESPAN       |");
        Console.WriteLine("| by : Feylin, Michelle, Ruby |");
        Console.WriteLine("+-----------------------------+");
        Console.WriteLine();

        Console.ReadKey();
        Console.Write("Usia: ");
        int usia = Convert.ToInt32(Console.ReadLine());
       
        bool ulang = true;

        while (ulang)
        {
            Console.Write("Jenis kelamin (L/P): ");
            string gender = Console.ReadLine().ToUpper();

            if (gender == "P" || gender == "L")
            {
                Console.Write("Tinggi badan (cm): ");
                double tinggiCm = Convert.ToInt32(Console.ReadLine());
                double tinggiM = tinggiCm / 100;

                Console.Write("Berat badan (kg): ");
                double berat = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();

                bool ulang2 = true;
                while (ulang2)
                {
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|       LONGER LIFESPAN       |");
                    Console.WriteLine("| by : Feylin, Michelle, Ruby |");
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine();
                    Console.WriteLine("TINGKAT KEAKTIFAN BERGERAK");
                    Console.WriteLine("[1] Sedentary (sedikit atau tidak berolahraga)");
                    Console.WriteLine("[2] Lightly Active (berolahraga 1-3 hari/minggu)");
                    Console.WriteLine("[3] Moderately Active (berolahraga 3-5 hari/minggu)");
                    Console.WriteLine("[4] Active (berolahraga 6-7 hari/minggu)");
                    Console.WriteLine("[5] Very Active (berolahraga secara intensif 6-7 hari/minggu)");
                    Console.Write("Tingkat keaktifan (1/2/3/4/5): ");
                    int aktif = Convert.ToInt32(Console.ReadLine());

                    Console.ReadKey();
                    Console.Clear();

                    if (aktif > 0 && aktif <= 5)
                    {
                        Console.WriteLine("+-----------------------------+");
                        Console.WriteLine("|       LONGER LIFESPAN       |");
                        Console.WriteLine("| by : Feylin, Michelle, Ruby |");
                        Console.WriteLine("+-----------------------------+");
                        Console.WriteLine();
                        double BMI = berat / (tinggiM * tinggiM);
                        Console.WriteLine($"BMI: {Math.Round(BMI, 1)}");

                        if (BMI < 18.5)
                        {
                            Console.WriteLine("Kategori BMI: Underweight");
                        }
                        else if (BMI >= 18.5 && BMI <= 24.9)
                        {
                            Console.WriteLine("Kategori BMI: Normal");
                        }
                        else if (BMI >= 25 && BMI <= 29.9)
                        {
                            Console.WriteLine("Kategori BMI: Overweight");
                        }
                        else if (BMI >= 30 && BMI <= 34.9)
                        {
                            Console.WriteLine("Kategori BMI: Obese");
                        }
                        else if (BMI >= 35)
                        {
                            Console.WriteLine("Kategori BMI: Extremely Obese");
                        }

                        if (gender == "P")
                        {
                            double AMR = 0;
                            Perempuan(gender, berat, tinggiCm, usia, aktif, AMR);
                        }
                        else if (gender == "L")
                        {
                            double AMR = 0;
                            LakiLaki(gender, berat, tinggiCm, usia, aktif, AMR);
                        }

                        ulang2 = false;
                        ulang = false;
                    }
                     else
                    {
                        ulang2 = true;
                    }    
                } 
            }
            else
            {
                ulang = true;
            }
        }
    } 
}