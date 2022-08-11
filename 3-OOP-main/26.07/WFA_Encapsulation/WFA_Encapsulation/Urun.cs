using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Encapsulation
{
    public class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public short Stok { get; set; }

        #region Encapsulation
        //private string _kategori;
        ///// <summary>
        ///// giyim haricinde bir kategori eklenemez!
        ///// </summary>
        //public string Kategori //telefon
        //{
        //    get
        //    {
        //        return _kategori;

        //    }
        //    set
        //    {
        //        if (value != "giyim")
        //        {
        //            _kategori = "Hatalı tanım!";
        //        }
        //        else
        //        {
        //            _kategori = value;
        //        }
        //    }
        //} 
        #endregion


        //read only
        public string Kategori
        {
            get
            {
                return "Giyim";
            }
        }

    }
}
