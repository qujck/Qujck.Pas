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
    public sealed class Indicator : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, Indicator> _list = new Dictionary<string, Indicator>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(Indicator a, Indicator b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(Indicator a, Indicator b)
        {
            return (a.Equals(b));
        }

		public static implicit operator Indicator(string value)
        {
            if (value == null || value.Trim().Length == 0) return Indicator.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("Indicator.{0} not found.", value));
        }

        public static implicit operator String(Indicator item)
        {
            return item.Value;
        }

        public static readonly Indicator Null = new Indicator("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Indicator N = new Indicator("N");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Indicator Y = new Indicator("Y");

        public static IEnumerable<Indicator> GetValues()
        {
            yield return Null;
		    yield return N;
		    yield return Y;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private Indicator _instance;

        private Indicator(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public Indicator()
        {
            _readonly = false;
            _instance = Indicator.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == Indicator.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = Indicator.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("Indicator.{0} not found.", value));
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
            Indicator item = (Indicator)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is Indicator)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                Indicator compare = (Indicator)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a Indicator.");
        }
        #endregion
    }
}