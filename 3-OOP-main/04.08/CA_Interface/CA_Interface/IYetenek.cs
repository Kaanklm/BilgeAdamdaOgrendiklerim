using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Interface
{
    public interface IYetenek //interfaceler impelement edilmek zorundadırlar. Interface içerisinde tanımlamış olduğumuz her bir yapı aslında zorunlu ezilebilir yapılardır.
    {

        string OtoPilot();



        /*
            Interfaceler, class gibi türler için oluştuulmuş modellerdir. Bir sınıfın temelde hangi eylemlerden oluşacağını belirleyen şablon yapılar. Bu sayede oluşturulacak olan sınıfların bir nevi sözleşmesini (arayüz) tanımlar. 

        -Sınıflara yetenek kazandırır.
        -Interface olarak tanımlanan class'dan instance alınamaz!
        -Bir sınıf birden fazla interfaceden miras alabilir.
         */
    }
}
