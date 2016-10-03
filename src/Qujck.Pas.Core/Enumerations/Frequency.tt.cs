//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Qujck.Pas.Core.Enumerations
{
    public sealed class Frequency : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, Frequency> _list = new Dictionary<string, Frequency>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(Frequency a, Frequency b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(Frequency a, Frequency b)
        {
            return (a.Equals(b));
        }

		public static implicit operator Frequency(string value)
        {
            if (value == null || value.Trim().Length == 0) return Frequency.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("Frequency.{0} not found.", value));
        }

        public static implicit operator String(Frequency item)
        {
            return item.Value;
        }

        public static readonly Frequency Null = new Frequency("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency Annually = new Frequency("Annually");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency Fortnightly = new Frequency("Fortnightly");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency FourWeekly = new Frequency("FourWeekly");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency HalfYearly = new Frequency("HalfYearly");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency Monthly = new Frequency("Monthly");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency Quarterly = new Frequency("Quarterly");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency Single = new Frequency("Single");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency Termly = new Frequency("Termly");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Frequency Weekly = new Frequency("Weekly");

        public static IEnumerable<Frequency> GetValues()
        {
            yield return Null;
		    yield return Annually;
		    yield return Fortnightly;
		    yield return FourWeekly;
		    yield return HalfYearly;
		    yield return Monthly;
		    yield return Quarterly;
		    yield return Single;
		    yield return Termly;
		    yield return Weekly;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private Frequency _instance;

        private Frequency(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public Frequency()
        {
            _readonly = false;
            _instance = Frequency.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == Frequency.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = Frequency.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("Frequency.{0} not found.", value));
                    _instance = _list[value];
                }
            }
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.GetType() != obj.GetType()) return false;

            // safe because of the GetType check
            Frequency item = (Frequency)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is Frequency)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                Frequency compare = (Frequency)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a Frequency.");
        }
        #endregion
    }
}