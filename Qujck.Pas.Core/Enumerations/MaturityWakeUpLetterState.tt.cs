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
    public sealed class MaturityWakeUpLetterState : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, MaturityWakeUpLetterState> _list = new Dictionary<string, MaturityWakeUpLetterState>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(MaturityWakeUpLetterState a, MaturityWakeUpLetterState b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(MaturityWakeUpLetterState a, MaturityWakeUpLetterState b)
        {
            return (a.Equals(b));
        }

		public static implicit operator MaturityWakeUpLetterState(string value)
        {
            if (value == null || value.Trim().Length == 0) return MaturityWakeUpLetterState.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("MaturityWakeUpLetterState.{0} not found.", value));
        }

        public static implicit operator String(MaturityWakeUpLetterState item)
        {
            return item.Value;
        }

        public static readonly MaturityWakeUpLetterState Null = new MaturityWakeUpLetterState("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaturityWakeUpLetterState Cancelled = new MaturityWakeUpLetterState("Cancelled");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaturityWakeUpLetterState Completed = new MaturityWakeUpLetterState("Completed");
        /// <summary>
        /// 
        /// </summary>
		public static readonly MaturityWakeUpLetterState Pending = new MaturityWakeUpLetterState("Pending");

        public static IEnumerable<MaturityWakeUpLetterState> GetValues()
        {
            yield return Null;
		    yield return Cancelled;
		    yield return Completed;
		    yield return Pending;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private MaturityWakeUpLetterState _instance;

        private MaturityWakeUpLetterState(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public MaturityWakeUpLetterState()
        {
            _readonly = false;
            _instance = MaturityWakeUpLetterState.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == MaturityWakeUpLetterState.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = MaturityWakeUpLetterState.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("MaturityWakeUpLetterState.{0} not found.", value));
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
            MaturityWakeUpLetterState item = (MaturityWakeUpLetterState)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is MaturityWakeUpLetterState)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                MaturityWakeUpLetterState compare = (MaturityWakeUpLetterState)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a MaturityWakeUpLetterState.");
        }
        #endregion
    }
}
