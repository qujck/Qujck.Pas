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
    public sealed class PurchaseStage : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, PurchaseStage> _list = new Dictionary<string, PurchaseStage>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(PurchaseStage a, PurchaseStage b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(PurchaseStage a, PurchaseStage b)
        {
            return (a.Equals(b));
        }

		public static implicit operator PurchaseStage(string value)
        {
            if (value == null || value.Trim().Length == 0) return PurchaseStage.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("PurchaseStage.{0} not found.", value));
        }

        public static implicit operator String(PurchaseStage item)
        {
            return item.Value;
        }

        public static readonly PurchaseStage Null = new PurchaseStage("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly PurchaseStage Booked = new PurchaseStage("Booked");
        /// <summary>
        /// 
        /// </summary>
		public static readonly PurchaseStage Settled = new PurchaseStage("Settled");

        public static IEnumerable<PurchaseStage> GetValues()
        {
            yield return Null;
		    yield return Booked;
		    yield return Settled;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private PurchaseStage _instance;

        private PurchaseStage(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public PurchaseStage()
        {
            _readonly = false;
            _instance = PurchaseStage.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == PurchaseStage.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = PurchaseStage.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("PurchaseStage.{0} not found.", value));
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
            PurchaseStage item = (PurchaseStage)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is PurchaseStage)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                PurchaseStage compare = (PurchaseStage)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a PurchaseStage.");
        }
        #endregion
    }
}
