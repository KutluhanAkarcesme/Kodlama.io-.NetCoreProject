using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductUpdate = "Ürünler güncellendi";
        public static string ProductCountOfCatgoryError = "Bir kategoride en fazla 10 adet ürün olabilir";
        public static string ProductNameAlreadyExist = "Bu isimde zaten başka bir isim var";
        public static string CategoryLimitExceded = "Kategori sayısı 15 den fazla olamaz";
    }
}
