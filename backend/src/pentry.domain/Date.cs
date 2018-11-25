using System;
using System.Globalization;

namespace pentry.domain
{
    public struct Date : IEquatable<Date>, IEquatable<DateTime>, IComparable<Date>
    {
        public Date(DateTime date)
        {
            value = date.Date;
        }

        public int Day => value.Day;

        public int Month => value.Month;

        public int Year => value.Year;

        public bool Equals(Date other)
        {
            return Equals((DateTime)other);
        }

        public bool Equals(DateTime other)
        {
            return value.Equals(other);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Date && Equals((Date)obj);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        public string ToString(string format)
        {
            return value.ToString(format);
        }

        public int CompareTo(Date date)
        {
            return ((DateTime)this).CompareTo(date);
        }

        public static implicit operator DateTime(Date date)
        {
            return date.value;
        }

        public static explicit operator Date(DateTime dateTime)
        {
            return new Date(dateTime);
        }

        public static bool operator >(Date first, Date second)
        {
            return ((DateTime)first).Date > ((DateTime)second).Date;
        }

        public static bool operator <(Date first, Date second)
        {
            return ((DateTime)first).Date < ((DateTime)second).Date;
        }

        public static bool operator >=(Date first, Date second)
        {
            return ((DateTime)first).Date >= ((DateTime)second).Date;
        }

        public static bool operator <=(Date first, Date second)
        {
            return ((DateTime)first).Date <= ((DateTime)second).Date;
        }

        public static bool operator ==(Date first, Date second)
        {
            return ((DateTime)first).Date == ((DateTime)second).Date;
        }

        public static bool operator !=(Date first, Date second)
        {
            return ((DateTime)first).Date != ((DateTime)second).Date;
        }

        private readonly DateTime value;

        public Date AddMonths(int months)
        {
            return (Date)value.AddMonths(months);
        }

        public Date AddDays(int days)
        {
            return (Date)value.AddDays(days);
        }
    }
}
