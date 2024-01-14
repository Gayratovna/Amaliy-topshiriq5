using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliy_topshiriq5
{
    public class Mashina
    {
        public string MashinaMarkasi { get; set; }
        public int IshlabChiqarilganYil { get; set; }
        public int YurganMasofasi { get; set; }

        public void Info()
        {
            Console.WriteLine($"Mashina markasi: {MashinaMarkasi}\n" +
                              $"Ishlab chiqarilgan yili: {IshlabChiqarilganYil}\n" +
                              $"Yurgan masofasi: {YurganMasofasi}");
        }

    }
}
