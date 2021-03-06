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
    public sealed class Title : IEnumeration, IComparable
    {
        #region static
        private static readonly Dictionary<string, Title> _list = new Dictionary<string, Title>();

        public static bool Contains(string key)
        {
            return _list.Any(x => x.Key == key);
        }

        public static bool operator !=(Title a, Title b)
        {
            return (!a.Equals(b));
        }

        public static bool operator ==(Title a, Title b)
        {
            return (a.Equals(b));
        }

		public static implicit operator Title(string value)
        {
            if (value == null || value.Trim().Length == 0) return Title.Null;
            if (Contains(value))
                return _list[value];
            else
                throw new InvalidCastException(string.Format("Title.{0} not found.", value));
        }

        public static implicit operator String(Title item)
        {
            return item.Value;
        }

        public static readonly Title Null = new Title("");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Title Dr = new Title("Dr");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Title Miss = new Title("Miss");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Title Mr = new Title("Mr");
        /// <summary>
        /// 
        /// </summary>
		public static readonly Title Mrs = new Title("Mrs");

        public static IEnumerable<Title> GetValues()
        {
            yield return Null;
		    yield return Dr;
		    yield return Miss;
		    yield return Mr;
		    yield return Mrs;
        }

        #endregion

        #region instance
        private readonly string _value;
        private readonly bool _readonly;
        private Title _instance;

        private Title(string value)
        {
            _readonly = true;
            _value = value;
            _instance = this;
            _list[value] = _instance;
        }

		public Title()
        {
            _readonly = false;
            _instance = Title.Null;
        }

		[XmlText]
        public string Value
        {
            get
            {
                if (_instance == Title.Null) return null;
                return _instance._value;
            }
            set
            {
                if (_readonly)
                    throw new InvalidOperationException("Cannot assign a value to an enumeration.");
                if (value == null) _instance = Title.Null;
                else
                {
                    if (!_list.ContainsKey(value))
                        throw new NullReferenceException(string.Format("Title.{0} not found.", value));
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
            Title item = (Title)obj;

            return System.Object.ReferenceEquals(_instance, item);
        }

        public override int GetHashCode()
        {
			if (_value == null) return "".GetHashCode();
            else return _value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is Title)
            {
				if (_instance.Value == null)
				{
					if (obj == null) return 0;
					else return -1;
				}
                Title compare = (Title)obj;
                return _instance.Value.CompareTo(compare.Value);
            }
            else
                throw new ArgumentException("Object is not a Title.");
        }
        #endregion
    }
}
