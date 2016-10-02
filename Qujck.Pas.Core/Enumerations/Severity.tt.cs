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
    public sealed class Severity : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, Severity> _list = new Dictionary<string, Severity>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(Severity a, Severity b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(Severity a, Severity b)
        {
            return (a.Equals(b));
        }

		public static implicit operator Severity(string value)
        {
            if (value == null || value.Trim().Length == 0) return Severity.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("Severity.{0} not found.", value));
        }

        public static implicit operator String(Severity item)
        {
            return item.Value;
        }

        public static readonly Severity Null = new Severity("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Severity Critical = new Severity("Critical");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Severity Error = new Severity("Error");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Severity Information = new Severity("Information");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Severity Security = new Severity("Security");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Severity Success = new Severity("Success");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Severity Unknown = new Severity("Unknown");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Severity Warning = new Severity("Warning");

        public static IEnumerable<Severity> GetValues()
        {
            yield return Null;
		    yield return Critical;
		    yield return Error;
		    yield return Information;
		    yield return Security;
		    yield return Success;
		    yield return Unknown;
		    yield return Warning;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private Severity _instance;

        private Severity(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public Severity()
        {
            _readonly = false;
            _instance = Severity.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == Severity.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = Severity.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("Severity.{0} not found.", value));
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
            Severity item = (Severity)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is Severity)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                Severity compare = (Severity)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a Severity.");
        }
        #endregion
    }
}