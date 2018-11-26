using FluentAssertions;
using NUnit.Framework;
using System;
namespace pentry.domain.tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Date_When_implicit_to_date_time
    {
        [Test]
        public void Then_year_is_equal()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);
            var date = new Date(dateTime);

            DateTime implicitDateTime = date;

            implicitDateTime.Year.Should().Be(dateTime.Year);
        }


        [Test]
        public void Then_month_is_equal()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);
            var date = new Date(dateTime);

            DateTime implicitDateTime = date;

            implicitDateTime.Month.Should().Be(dateTime.Month);
        }


        [Test]
        public void Then_day_is_equal()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);
            var date = new Date(dateTime);

            DateTime implicitDateTime = date;

            implicitDateTime.Day.Should().Be(dateTime.Day);
        }


        [Test]
        public void Then_hours_are_zero()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);
            var date = new Date(dateTime);

            DateTime implicitDateTime = date;

            implicitDateTime.Hour.Should().Be(0);
        }


        [Test]
        public void Then_minutes_are_zero()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);
            var date = new Date(dateTime);

            DateTime implicitDateTime = date;

            implicitDateTime.Minute.Should().Be(0);
        }

        [Test]
        public void Then_seconds_are_zero()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);
            var date = new Date(dateTime);

            DateTime implicitDateTime = date;

            implicitDateTime.Second.Should().Be(0);
        }

        [Test]
        public void Then_milliseconds_are_zero()
        {
            var dateTime = new DateTime(2017, 1, 1, 22, 12, 33);
            var date = new Date(dateTime);

            DateTime implicitDateTime = date;

            implicitDateTime.Millisecond.Should().Be(0);
        }
    }
}
