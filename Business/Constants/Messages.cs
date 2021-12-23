using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Bilgileri Güncellendi";
        public static string CarListed = "Araçlar Listelendi";
        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        public static string CarIsNotAvailable = "Bu Araç Mevcut Değil";

        public static string BrandIsNotInvalid = "Marka Geçersiz";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandIsNotAvailable = "Marka Mevcut Değil";

        public static string ColorIsNotInvalid = "Renk Geçersiz";
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorIsNotAvailable = "Renk Mevcut Değil";
        internal static object MaintenanceTime="zaman aşımı";
        internal static string RentalAdded;
        internal static string RentalNameInvalid;
        internal static string RentalDeleted;
        internal static string RentalListed;
        internal static string RentalsListed;
        internal static string RentalUpdated;
        internal static string CustomerAdded;
        internal static string CustomerDeleted;
        internal static string CustomerUpdated;
        internal static string UserAdded;
        internal static string UserDeleted;
        internal static string UserUpdated;
    }
}
