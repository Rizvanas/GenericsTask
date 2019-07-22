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
                var result1 = EnumMapper.MapValueToEnum<Weekday, int>(2);
                var result2 = EnumMapper.MapValueToEnum<Gender, int>(2);
                var result3 = EnumMapper.MapValueToEnum<Gender, string>("Male");
                var result4 = EnumMapper.MapValueToEnum<Gender, string>("Female");
                var result5 = EnumMapper.MapValueToEnum<Weekday, string>("Friday");
                var result6 = EnumMapper.MapValueToEnum<Weekday, string>("asdasdasdad");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
