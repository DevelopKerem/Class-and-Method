using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassIntro.Program;

namespace ClassIntro
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Ürününüz : " + product.StokAdedi);
        }
    }
}
