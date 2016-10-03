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
    public sealed class ChangeBasis : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, ChangeBasis> _list = new Dictionary<string, ChangeBasis>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(ChangeBasis a, ChangeBasis b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(ChangeBasis a, ChangeBasis b)
        {
            return (a.Equals(b));
        }

		public static implicit operator ChangeBasis(string value)
        {
            if (value == null || value.Trim().Length == 0) return ChangeBasis.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("ChangeBasis.{0} not found.", value));
        }

        public static implicit operator String(ChangeBasis item)
        {
            return item.Value;
        }

        public static readonly ChangeBasis Null = new ChangeBasis("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly ChangeBasis DecreasingFamilyIncomeBenefit = new ChangeBasis("DecreasingFamilyIncomeBenefit");
        /// <summary>
        /// 
        /// </summary>
		public static readonly ChangeBasis DecreasingFixedPercentage = new ChangeBasis("DecreasingFixedPercentage");
        /// <summary>
        /// 
        /// </summary>
		public static readonly ChangeBasis DecreasingGiftIntervivos = new ChangeBasis("DecreasingGiftIntervivos");
        /// <summary>
        /// 
        /// </summary>
		public static readonly ChangeBasis DecreasingMortgageProtection = new ChangeBasis("DecreasingMortgageProtection");
        /// <summary>
        /// 
        /// </summary>
		public static readonly ChangeBasis Increasing = new ChangeBasis("Increasing");
        /// <summary>
        /// 
        /// </summary>
		public static readonly ChangeBasis Level = new ChangeBasis("Level");

        public static IEnumerable<ChangeBasis> GetValues()
        {
            yield return Null;
		    yield return DecreasingFamilyIncomeBenefit;
		    yield return DecreasingFixedPercentage;
		    yield return DecreasingGiftIntervivos;
		    yield return DecreasingMortgageProtection;
		    yield return Increasing;
		    yield return Level;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private ChangeBasis _instance;

        private ChangeBasis(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public ChangeBasis()
        {
            _readonly = false;
            _instance = ChangeBasis.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == ChangeBasis.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = ChangeBasis.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("ChangeBasis.{0} not found.", value));
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
            ChangeBasis item = (ChangeBasis)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is ChangeBasis)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                ChangeBasis compare = (ChangeBasis)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a ChangeBasis.");
        }
        #endregion
    }
}