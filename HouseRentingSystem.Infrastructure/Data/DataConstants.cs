using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem2._0.Infrastructure.Data
{
    public static class DataConstants
    {
        public static class Category
        {
            public const int NameMaxLength = 50;
        }

        public static class House
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 10;

            public const int AddressMaxLength = 150;
            public const int AddressMinLength = 30;

            public const int DescriptionMaxLength = 500;
            public const int DescriptionMinLength = 50;

            public const string PricePerMonthMaxValue = "2000.00";
            public const string PricePerMonthMinValue = "0.00";
        }

        public static class Agent
        {
            public const int PhoneNumberMaxLenth = 15;
            public const int PhoneNumberMinLength = 7;
        }
    }

}
