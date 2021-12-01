using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiEnvanteri
{
    public static class KisiContext //static nesneler ramda her zaman bir tanedir. instance alamayız. 
    {
       private static  string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"/kisiler.json"; //dosyanın olduğu yer
        public static List<Kisi> Kisiler { get; set; } = new List<Kisi>();
       
        public static void Load()
        {
            if (File.Exists(_path))
            {
                try
                {
                    FileStream fileStream = new FileStream(_path, FileMode.Open); //dosya varsa içine kaydet yoksa oluşturup kaydet : openorcreate komutu ile 
                    StreamReader reader = new StreamReader(fileStream);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    Kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                    
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(ex);
                } 
            }
           
        }
        public static void Save()
        {
                       
            try
            {
              
                //listi Json serialize ediyoruz
                FileStream fileStream = new FileStream(_path, FileMode.Open); //Filestream :dosyayı okumak için
                StreamWriter writer = new StreamWriter(fileStream); //dönüştürme için streame ihtiyacımız olacak her zaman.Ramden diske diskten rame işlemler yapıyoruz.
                writer.Write(JsonConvert.SerializeObject(Kisiler, Formatting.Indented));
                writer.Close();
                writer.Dispose();
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
