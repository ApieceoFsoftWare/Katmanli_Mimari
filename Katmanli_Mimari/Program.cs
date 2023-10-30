using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli_Mimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UI: User Interface
            BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
            businessLogicLayer.SaveData(1, "Ozan Berkay", "ÖZCAN");


            /*
             * Burada yaptığımız uygulama esasında sadece katmanlı mimariyi anlamak için bir ön izleme gibidir...
             * 
             * Sırası ile DataAccessLayer > BusinesLogicalLayer oluşturduk...
             * DataAccessLayer'da inceleyip göreceğiniz gibi olması gereken bazı değişkenler ve yapıcı metodu oluşturduk.
             * Yapıcı metot içinde connection stringi oluşturduk ve her çağrıldığında database'e ulaşmayı sağladık.
             * Hemen arkasından connection'ımızın durumunu belirleyen bir metot ve veriyi kaydeden bir metot yazdık...
             * 
             * BusinessLogicalLayer'da bu katmanı örneklerken aynı anda DataAccessLayer'ı da örnekleyen bir kod yazdık.
             * Bunun sayesinde BusinessLogicLayer RAM'de ayağa kalktığında aslında DataAccessLayer'da ayağa kalkmış olacak.
             * Burada veriyi kontrol edip kaydetme işlemleri için bazı kodlar yazdık inceleyebilirsin.
             * En sonunda bu sayfaya yani program.cs e gelip (Bir nevi UI alanı gibi düşünüşebilir.) Burada yaptığımız işlemleri kontrol etmek için Debug attık... 
             * 
             * Sen de debug at ve nasıl çalıştığını gör!
             * 
             */

        }
    }
}
