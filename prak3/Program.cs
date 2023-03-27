using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil = new Mobil();

            mobil.Warna = "Hitam";
            mobil.merek = "Daihaha";
            mobil.model = "Cylock";
            mobil.tahun_keluaran = "2018";
            mobil.kecepatan = "60 km/jam";
            mobil.suara = "TINTINNNN";
            mobil.jumlah_pintu = "5\n";
            mobil.Tampilkan_info = "info";

            mobil.warna();
            mobil.merk();
            mobil.models();
            mobil.year();
            mobil.gas();
            mobil.klakson();
            mobil.pintu();
            mobil.tampilkan_info();

            Console.ReadKey();
        }
    }
}
