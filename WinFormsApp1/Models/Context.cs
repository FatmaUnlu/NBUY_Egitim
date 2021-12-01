using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm_Form.Models
{
   public class Context
    {
        public Context() //her newleddiğimde örneğin 100 tane veri üreticem onu ayarlıcam burda
        {
            for (int i = 0; i < 100; i++)
            {
                Kisiler.Add(new Kisi()
                {
                    Ad = Faker.NameFaker.FirstName(),
                    Soyad = Faker.NameFaker.LastName(),
                    DogumTarihi = Faker.DateTimeFaker.DateTimeBetweenYears(1970, 1990),
                    Falan = Faker.NumberFaker.Number(1000, 9999)
                }) ;
            }
        }
        public List<Kisi> Kisiler { get; set; } = new List<Kisi>();

    }
}
