using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak3
{
    public class Mobil
    {
        public string Warna { get; set; }
        public string merek { get; set; }
        public string model { get; set; }
        public string tahun_keluaran { get; set; }
        public string kecepatan { get; set; }
        public string suara { get; set; }
        public string jumlah_pintu { get; set; }
        public string Tampilkan_info { get; set; }

        public void warna()
        {
            Console.WriteLine("warna : {0}", Warna);
        }
        public void merk()
        {
            Console.WriteLine("merek : {0}", merek);
        }
        public void models()
        {
            Console.WriteLine("model : {0}", model);
        }
        public void year()
        {
            Console.WriteLine("tahun keluaran : {0}", tahun_keluaran);
        }
        public void gas()
        {
            Console.WriteLine($"Mobil {model}, berjalan dengan kecepatan : {kecepatan}", kecepatan);
        }
        public void klakson()
        {
            Console.WriteLine("suara klakson : {0}", suara);
        }
        public void pintu()
        {
            Console.WriteLine("jumlah pintu : {0}", jumlah_pintu);
        }
        public void tampilkan_info()
        {
            Console.WriteLine($"Mobil saya berwarna {Warna}, merek {merek}, model {model}, keluaran tahun {tahun_keluaran}, dengan jumlah pintu sebanyak {jumlah_pintu}", Tampilkan_info);
        }
           
    }
}
