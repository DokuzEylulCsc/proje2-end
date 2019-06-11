using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class Sistem
    {
        List<Oda> bulunanOdalar = new List<Oda>();

        internal List<Oda> BulunanOdalar { get => bulunanOdalar; set => bulunanOdalar = value; }

        public void OdaAra(string odaTuru, string odaOzelligi, string sehir)
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\TumOtellereAitOdalar\";


            string[] fileEntries = Directory.GetFiles(filePath);

            foreach (var element in fileEntries)
            {
                //newton soft json okuma
                // read file into a string and deserialize JSON to a type
                Oda oda = JsonConvert.DeserializeObject<Oda>(File.ReadAllText(element));

                if (oda.OdaTuru == odaTuru && oda.OdaOzelligi == odaOzelligi && oda.SehirBilgisi == sehir)
                {
                    BulunanOdalar.Add(oda);
                }
            }

        }

        // Sistem üyenin isteğine uyan her bir oteli üyeye geri bildirir.
        // JSONVeri klasorundeki Otellerdeki Odalari Arayip kullaniciya bilgi vermeli.
        //public List<Oda> UyeyeUygunOtelleriListele()
        //{
        //    return new List<Oda>();
        //}
    }
}
