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
        public static string AuthorizationDenied = "SecuredOperation Hatası Yetkiniz Yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
    }
}
