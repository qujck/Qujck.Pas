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
    public sealed class FundUnitHoldingValueStatus : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, FundUnitHoldingValueStatus> _list = new Dictionary<string, FundUnitHoldingValueStatus>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(FundUnitHoldingValueStatus a, FundUnitHoldingValueStatus b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(FundUnitHoldingValueStatus a, FundUnitHoldingValueStatus b)
        {
            return (a.Equals(b));
        }

		public static implicit operator FundUnitHoldingValueStatus(string value)
        {
            if (value == null || value.Trim().Length == 0) return FundUnitHoldingValueStatus.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("FundUnitHoldingValueStatus.{0} not found.", value));
        }

        public static implicit operator String(FundUnitHoldingValueStatus item)
        {
            return item.Value;
        }

        public static readonly FundUnitHoldingValueStatus Null = new FundUnitHoldingValueStatus("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly FundUnitHoldingValueStatus Ok = new FundUnitHoldingValueStatus("Ok");
        /// <summary>
        /// 
        /// </summary>
		public static readonly FundUnitHoldingValueStatus Warning = new FundUnitHoldingValueStatus("Warning");

        public static IEnumerable<FundUnitHoldingValueStatus> GetValues()
        {
            yield return Null;
		    yield return Ok;
		    yield return Warning;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private FundUnitHoldingValueStatus _instance;

        private FundUnitHoldingValueStatus(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public FundUnitHoldingValueStatus()
        {
            _readonly = false;
            _instance = FundUnitHoldingValueStatus.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == FundUnitHoldingValueStatus.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = FundUnitHoldingValueStatus.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("FundUnitHoldingValueStatus.{0} not found.", value));
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
            FundUnitHoldingValueStatus item = (FundUnitHoldingValueStatus)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is FundUnitHoldingValueStatus)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                FundUnitHoldingValueStatus compare = (FundUnitHoldingValueStatus)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a FundUnitHoldingValueStatus.");
        }
        #endregion
    }
}