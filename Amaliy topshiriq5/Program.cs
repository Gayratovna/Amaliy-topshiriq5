using Amaliy_topshiriq5;
using System.Reflection.PortableExecutable;



Mashina mashina1 = new Mashina { MashinaMarkasi = "Toyota", IshlabChiqarilganYil = 2020, YurganMasofasi = 15000 };
Mashina mashina2 = new Mashina { MashinaMarkasi = "Honda", IshlabChiqarilganYil = 2018, YurganMasofasi = 22000 };
Mashina mashina3 = new Mashina { MashinaMarkasi = "Ford", IshlabChiqarilganYil = 2023, YurganMasofasi = 5000 };

mashina1.Info();
Console.WriteLine(); 
mashina2.Info();
Console.WriteLine();
mashina3.Info();