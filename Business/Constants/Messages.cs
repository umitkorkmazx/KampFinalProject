using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Aynı isimde Ürün var";
        public static string CategoryLimitExceded = "Kategori limit aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifrenizi kontrol ediniz.";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
    }
}
