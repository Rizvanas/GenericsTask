using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTask.Mappers
{
    public static class EnumMapper
    {
        public static TEnum MapValueToEnum<TValue, TEnum>(TValue value) where TEnum : struct
        {
            TEnum result;
            if (!Enum.TryParse(value.ToString(), out result) 
                || !Enum.IsDefined(typeof(TEnum), value))
            {
                throw new Exception($"Value '{value}' is not part of {typeof(TEnum).Name} enum");
            }

            return result;
        }
    }
}
