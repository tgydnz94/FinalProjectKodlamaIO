using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
		public static string ProductCountOfCategoryError="Kategori için izin verilen sayı aşıldı";
		public static string ProductNameAlreadyExist="Bu isim kullanılıyor";
		public static string CategoryLimitExceded="Limit aşıldı";
		public static string AuthorizationDenied ="Yetkiniz yok";
		public static string SuccessfulLogin="Giriş başarılı";
		public static string UserNotFound="Kullanıcı bulunamadı";
		public static string UserRegistered="Kayıtlı kullanıcı";
		public static string UserAlreadyExists="Kullanıcı zaten var";
		public static string PasswordError="Mail veya şifre hatalı";
		public static string AccessTokenCreated="Token oluşturuldu";
	}
}
