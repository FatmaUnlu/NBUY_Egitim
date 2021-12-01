using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm_Form.Models
{
    public class Kisi
    {
        public Guid Id { get; set; } = Guid.NewGuid();// benzersiz kod üretir Guid. 1 2 3 4diye ilerlemez. daha karmaşık.
        public string  Ad{ get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Falan { get; set; }

        public override string ToString() => $"{Ad} {Soyad}";
        

    }
}
