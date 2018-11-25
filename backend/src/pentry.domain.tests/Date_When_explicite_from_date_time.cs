using System;
using FluentAssertions;
using NUnit.Framework;

namespace pentry.domain.tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Date_When_explicite_from_date_time
    {

        [Test]
        public void Then_year_is_equal()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);

            var expliciteDate = (Date)dateTime;

            expliciteDate.Year.As<int>().Should().Be(dateTime.Year);
        }

        [Test]
        public void Then_month_is_equal()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);

            var expliciteDate = (Date)dateTime;
            
            expliciteDate.Month.As<int>().Should().Be(dateTime.Month);
        }


        [Test]
        public void Then_day_is_equal()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);

            var expliciteDate = (Date)dateTime;
            
            expliciteDate.Day.As<int>().Should().Be(dateTime.Day);
        }
    }
}