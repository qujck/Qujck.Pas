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
    public sealed class MaritalState : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, MaritalState> _list = new Dictionary<string, MaritalState>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(MaritalState a, MaritalState b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(MaritalState a, MaritalState b)
        {
            return (a.Equals(b));
        }

		public static implicit operator MaritalState(string value)
        {
            if (value == null || value.Trim().Length == 0) return MaritalState.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("MaritalState.{0} not found.", value));
        }

        public static implicit operator String(MaritalState item)
        {
            return item.Value;
        }

        public static readonly MaritalState Null = new MaritalState("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaritalState Cohabitant = new MaritalState("Cohabitant");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaritalState Divorced = new MaritalState("Divorced");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaritalState IntendToMarry = new MaritalState("IntendToMarry");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaritalState Married = new MaritalState("Married");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaritalState Separated = new MaritalState("Separated");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaritalState Single = new MaritalState("Single");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaritalState Widowed = new MaritalState("Widowed");

        public static IEnumerable<MaritalState> GetValues()
        {
            yield return Null;
		    yield return Cohabitant;
		    yield return Divorced;
		    yield return IntendToMarry;
		    yield return Married;
		    yield return Separated;
		    yield return Single;
		    yield return Widowed;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private MaritalState _instance;

        private MaritalState(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public MaritalState()
        {
            _readonly = false;
            _instance = MaritalState.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == MaritalState.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = MaritalState.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("MaritalState.{0} not found.", value));
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
            MaritalState item = (MaritalState)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is MaritalState)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                MaritalState compare = (MaritalState)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a MaritalState.");
        }
        #endregion
    }
}
