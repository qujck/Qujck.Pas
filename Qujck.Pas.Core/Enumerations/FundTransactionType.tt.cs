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
    public sealed class FundTransactionType : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, FundTransactionType> _list = new Dictionary<string, FundTransactionType>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(FundTransactionType a, FundTransactionType b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(FundTransactionType a, FundTransactionType b)
        {
            return (a.Equals(b));
        }

		public static implicit operator FundTransactionType(string value)
        {
            if (value == null || value.Trim().Length == 0) return FundTransactionType.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("FundTransactionType.{0} not found.", value));
        }

        public static implicit operator String(FundTransactionType item)
        {
            return item.Value;
        }

        public static readonly FundTransactionType Null = new FundTransactionType("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly FundTransactionType Buy = new FundTransactionType("Buy");
        /// <summary>
        /// 
        /// </summary>
		public static readonly FundTransactionType Sell = new FundTransactionType("Sell");

        public static IEnumerable<FundTransactionType> GetValues()
        {
            yield return Null;
		    yield return Buy;
		    yield return Sell;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private FundTransactionType _instance;

        private FundTransactionType(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public FundTransactionType()
        {
            _readonly = false;
            _instance = FundTransactionType.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == FundTransactionType.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = FundTransactionType.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("FundTransactionType.{0} not found.", value));
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
            FundTransactionType item = (FundTransactionType)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is FundTransactionType)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                FundTransactionType compare = (FundTransactionType)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a FundTransactionType.");
        }
        #endregion
    }
}