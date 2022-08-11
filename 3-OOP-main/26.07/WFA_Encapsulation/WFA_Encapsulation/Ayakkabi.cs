using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Encapsulation
{
    public class Ayakkabi
    {
        //bir ayakkabının .... 'sı olur.

        /*
            -Encapsulation (Kapsülleme)
            -Inheritance (Miras/Kalıtım)
            -Polymorphism (Çok biçimlilik)
            -Abstraction (Soyutlama)
         */

        //public string marka;

        //Encapsulation: Nesnenin üyelerine yapılan erişimin kontrol altına alınmasına ve bu kontrolün nesnenin kendisi tarafından yapılmasını sağlamasıdır. Amaç; field'ları private yaparak bu alanlara dışarıdan erişimi önlemek ve get-set metotları ile konttrolü sağlamaktır.

        private string _marka;
        //property
        public string marka
        {
            get //getter
            {
                return _marka;
            }
            set //setter
            {
                if (value != "adidas")
                {
                    _marka = "tanımsız marka";
                }
                else
                {
                    _marka = value;
                }
            }
        }

        public string Tur { get; set; }

        private int _numara;
        public int Numara//value
        {
            get
            {
                return _numara;
            }
            set
            {
                if (value > 36 && value < 44)
                {
                    _numara = value;
                }
                else
                {
                    MessageBox.Show("sadece 36 ve 44 numara ekleyebilirsiniz");
                }

            }
        }

        private string _renk = "siyah";
        public string Renk { get { return _renk; } } //read only => sadece içerisinde bulunan değer okunur. herhangi bir değer ataması yapılamaz.

        public decimal Fiyat { get; set; }//100

        public decimal KdvDahilFiyat
        {
            //read only
            get
            {
                return Fiyat + (Fiyat * 0.18m);
            }
        }

    }
}
