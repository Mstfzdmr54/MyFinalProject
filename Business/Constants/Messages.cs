using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProducNameInvalid = "Ürün ismi geçersiz ";

        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductsListed = "Sistem Dinleniyor";
        public static string ProductCountOfCategoryError = "bir kategroide en fazla 10 ürün olabilir ";
        public static string ProducNameAlreadyExists = "Bu isim mevcut ";
        public static string AuthorizationDenied = "yetkiniz yok";

        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static User PasswordError { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static string UserRegistered { get; internal set; }
    }
}
