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
    public sealed class ProductType : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, ProductType> _list = new Dictionary<string, ProductType>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(ProductType a, ProductType b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(ProductType a, ProductType b)
        {
            return (a.Equals(b));
        }

		public static implicit operator ProductType(string value)
        {
            if (value == null || value.Trim().Length == 0) return ProductType.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("ProductType.{0} not found.", value));
        }

        public static implicit operator String(ProductType item)
        {
            return item.Value;
        }

        public static readonly ProductType Null = new ProductType("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly ProductType Endowment = new ProductType("Endowment");
        /// <summary>
        /// 
        /// </summary>
		public static readonly ProductType InvestmentBond = new ProductType("InvestmentBond");

        public static IEnumerable<ProductType> GetValues()
        {
            yield return Null;
		    yield return Endowment;
		    yield return InvestmentBond;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private ProductType _instance;

        private ProductType(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public ProductType()
        {
            _readonly = false;
            _instance = ProductType.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == ProductType.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = ProductType.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("ProductType.{0} not found.", value));
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
            ProductType item = (ProductType)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is ProductType)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                ProductType compare = (ProductType)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a ProductType.");
        }
        #endregion
    }
}