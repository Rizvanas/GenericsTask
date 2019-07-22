using GenericsTask.Enums;
using GenericsTask.Mappers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTask.Tests
{
    [TestFixture]
    public class EnumMapperTests
    {
        [Test]
        public void MapValueToEnum_MapStringToGender_StringValueIsMale_ResultIsMaleEnum()
        {
            var maleGender = EnumMapper.MapValueToEnum<string, Gender>("Male");
            Assert.AreEqual(Gender.Male, maleGender);
        }

        [Test]
        public void MapValueToEnum_MapStringToGender_StringValueIsFemale_ResultIsFemaleEnum()
        {
            var femaleGender = EnumMapper.MapValueToEnum<string, Gender>("Female");
            Assert.AreEqual(Gender.Female, femaleGender);
        }

        [Test]
        public void MapValueToEnum_MapStringToGender_StringValueIsOther_ThrowsException()
        {
            Assert.That(() => EnumMapper.MapValueToEnum<string, Gender>("Other"), Throws.Exception);
        }

        [Test]
        public void MapValueToEnum_MapIntToGender_IntValueIs1_ResultIsMaleEnum()
        {
            var maleGender = EnumMapper.MapValueToEnum<int, Gender>(1);
            Assert.AreEqual(Gender.Male, maleGender);
        }

        [Test]
        public void MapValueToEnum_MapIntToGender_IntValueIs2_ResultIsFemaleEnum()
        {
            var femaleGender = EnumMapper.MapValueToEnum<int, Gender>(2);
            Assert.AreEqual(Gender.Female, femaleGender);
        }

        [Test]
        public void MapValueToEnum_MapIntToGender_IntValueIs0_ThrowsException()
        {
            Assert.That(() => EnumMapper.MapValueToEnum<int, Gender>(0), Throws.Exception);
        }

        [Test]
        public void MapValueToEnum_MapStringToWeekday_StringValueIsMonday_ResultIsMondayEnum()
        {
            var monday = EnumMapper.MapValueToEnum<string, Weekday>("Monday");
            Assert.AreEqual(Weekday.Monday, monday);
        }

        [Test]
        public void MapValueToEnum_MapIntToWeekday_IntValueIs0_ResultIsMondayEnum()
        {
            var monday = EnumMapper.MapValueToEnum<int, Weekday>(0);
            Assert.AreEqual(Weekday.Monday, monday);
        }

        [Test]
        public void MapValueToEnum_MapStringWeekday_StringValueIsOther_ThrowsException()
        {
            Assert.That(() => EnumMapper.MapValueToEnum<string, Weekday>("Other"), Throws.Exception);
        }

        [Test]
        public void MapValueToEnum_MapIntToWeekday_IntValueIs100_ThrowsException()
        {
            Assert.That(() => EnumMapper.MapValueToEnum<int, Weekday>(100), Throws.Exception);
        }

        [Test]
        public void MapValueToEnum_MapWeekdayToGender_ThrowsException()
        {
            Assert.That(() => EnumMapper.MapValueToEnum<Weekday, Gender>(Weekday.Monday), Throws.Exception);
        }
    }
}
