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
    public sealed class AlertState : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, AlertState> _list = new Dictionary<string, AlertState>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(AlertState a, AlertState b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(AlertState a, AlertState b)
        {
            return (a.Equals(b));
        }

		public static implicit operator AlertState(string value)
        {
            if (value == null || value.Trim().Length == 0) return AlertState.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("AlertState.{0} not found.", value));
        }

        public static implicit operator String(AlertState item)
        {
            return item.Value;
        }

        public static readonly AlertState Null = new AlertState("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly AlertState Closed = new AlertState("Closed");
        /// <summary>
        /// 
        /// </summary>
		public static readonly AlertState New = new AlertState("New");

        public static IEnumerable<AlertState> GetValues()
        {
            yield return Null;
		    yield return Closed;
		    yield return New;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private AlertState _instance;

        private AlertState(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public AlertState()
        {
            _readonly = false;
            _instance = AlertState.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == AlertState.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = AlertState.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("AlertState.{0} not found.", value));
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
            AlertState item = (AlertState)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is AlertState)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                AlertState compare = (AlertState)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a AlertState.");
        }
        #endregion
    }
}