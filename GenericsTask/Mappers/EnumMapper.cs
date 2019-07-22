using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTask.Mappers
{
    public static class EnumMapper
    {
        public static TEnum MapValueToEnum<TEnum, TValue>(TValue value) where TEnum : struct
        {
            TEnum result;
            if (!Enum.TryParse<TEnum>(value.ToString(), out result))
            {
                throw new Exception($"Value '{value}' is not part of {typeof(TEnum).Name} enum");
            }

            return result;
        }
    }
}
