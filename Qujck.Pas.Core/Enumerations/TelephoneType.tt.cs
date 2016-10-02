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
    public sealed class TelephoneType : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, TelephoneType> _list = new Dictionary<string, TelephoneType>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(TelephoneType a, TelephoneType b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(TelephoneType a, TelephoneType b)
        {
            return (a.Equals(b));
        }

		public static implicit operator TelephoneType(string value)
        {
            if (value == null || value.Trim().Length == 0) return TelephoneType.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("TelephoneType.{0} not found.", value));
        }

        public static implicit operator String(TelephoneType item)
        {
            return item.Value;
        }

        public static readonly TelephoneType Null = new TelephoneType("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly TelephoneType Daytime = new TelephoneType("Daytime");
        /// <summary>
        /// 
        /// </summary>
		public static readonly TelephoneType Evening = new TelephoneType("Evening");
        /// <summary>
        /// 
        /// </summary>
		public static readonly TelephoneType Mobile = new TelephoneType("Mobile");

        public static IEnumerable<TelephoneType> GetValues()
        {
            yield return Null;
		    yield return Daytime;
		    yield return Evening;
		    yield return Mobile;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private TelephoneType _instance;

        private TelephoneType(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public TelephoneType()
        {
            _readonly = false;
            _instance = TelephoneType.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == TelephoneType.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = TelephoneType.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("TelephoneType.{0} not found.", value));
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
            TelephoneType item = (TelephoneType)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is TelephoneType)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                TelephoneType compare = (TelephoneType)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a TelephoneType.");
        }
        #endregion
    }
}
