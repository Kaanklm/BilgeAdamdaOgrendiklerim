using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Constructor
{
    public class Bebek
    {
        /*
         Constructor: Yapılandırı Metot

            Görevi oluşturulan nesneyi ilk kullanıma hazırlamasıdır. Bir class'dan instance alındığında ilk tetiklenen metottur.

        Constructor isimleri class ismi ile aynı olmak zorundadır.
         */

        /// <summary>
        /// boş bırakılırsa doğum tarihi otomatik tanımlanır.
        /// </summary>
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
        }

        /// <summary>
        /// string tipte anne adı ve doğum tarihi tanımlanır.
        /// </summary>
        /// <param name="_anneAdi"></param>
        public Bebek(string _anneAdi)
        {
            DogumTarihi = DateTime.Now;
            AnneAdi = _anneAdi;
        }

        /// <summary>
        /// string anne adı, string baba adı ve otomatik doğum tarihi
        /// </summary>
        /// <param name="_anneAdi"></param>
        /// <param name="_babaAdi"></param>
        public Bebek(string _anneAdi, string _babaAdi)
        {
            DogumTarihi = DateTime.Now;
            AnneAdi = _anneAdi;
            BabaAdi = _babaAdi;
        }

        //snippets
        //prop+tab+tab => property
        //ctor=> contructor

        public Bebek(string _cinsiyet, double _kilo, double _boy, string _anneAdi, string _babaAdi, string Soyad)
        {
            DogumTarihi = DateTime.Now;
            Cinsiyet = _cinsiyet;
            Kilo = _kilo;
            Boy = _boy;
            AnneAdi = _anneAdi;
            BabaAdi = _babaAdi;
            this.Soyad = Soyad;
        }
        



        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public double Kilo { get; set; }
        public double Boy { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public string Soyad { get; set; }


    }
}
