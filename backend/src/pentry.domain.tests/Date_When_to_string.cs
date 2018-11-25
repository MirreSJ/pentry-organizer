using FluentAssertions;
using NUnit.Framework;
using System;

namespace pentry.domain.tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Date_When_to_string
    {
        [Test]
        public void Then_returns_yyyy_MM_dd()
        {
            var date1 = new Date(new DateTime(2017, 1, 1));
            var date2 = new Date(new DateTime(2017, 12, 31));

            date1.ToString().Should().Be("2017-01-01");
            date2.ToString().Should().Be("2017-12-31");
        }

        [Test]
        public void Then_returns_date_in_right_format()
        {
            var date1 = new Date(new DateTime(2017, 1, 1));

            var formattedDate = date1.ToString("dd.MM.yyyy");

            formattedDate.Should().Be("01.01.2017");
        }
    }
}
