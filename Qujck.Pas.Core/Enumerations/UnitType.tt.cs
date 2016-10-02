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
    public sealed class UnitType : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, UnitType> _list = new Dictionary<string, UnitType>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(UnitType a, UnitType b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(UnitType a, UnitType b)
        {
            return (a.Equals(b));
        }

		public static implicit operator UnitType(string value)
        {
            if (value == null || value.Trim().Length == 0) return UnitType.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("UnitType.{0} not found.", value));
        }

        public static implicit operator String(UnitType item)
        {
            return item.Value;
        }

        public static readonly UnitType Null = new UnitType("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly UnitType Accumulation = new UnitType("Accumulation");
        /// <summary>
        /// 
        /// </summary>
		public static readonly UnitType Income = new UnitType("Income");
        /// <summary>
        /// 
        /// </summary>
		public static readonly UnitType Initial = new UnitType("Initial");

        public static IEnumerable<UnitType> GetValues()
        {
            yield return Null;
		    yield return Accumulation;
		    yield return Income;
		    yield return Initial;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private UnitType _instance;

        private UnitType(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public UnitType()
        {
            _readonly = false;
            _instance = UnitType.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == UnitType.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = UnitType.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("UnitType.{0} not found.", value));
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
            UnitType item = (UnitType)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is UnitType)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                UnitType compare = (UnitType)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a UnitType.");
        }
        #endregion
    }
}
