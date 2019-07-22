using GenericsTask.Enums;
using GenericsTask.Mappers;
using System;

namespace GenericsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var result1 = EnumMapper.MapValueToEnum<int, Weekday>(2);
                var result2 = EnumMapper.MapValueToEnum<int, Gender>(2);
                var result3 = EnumMapper.MapValueToEnum<string, Gender>("Male");
                var result4 = EnumMapper.MapValueToEnum<string, Gender>("Female");
                var result5 = EnumMapper.MapValueToEnum<string, Weekday>("Friday");
                var result6 = EnumMapper.MapValueToEnum<string, Weekday>("asdasdasdad");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
