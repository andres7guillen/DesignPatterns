using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Maybe
{
    public struct Maybe<T> : IEquatable<Maybe<T>>
        where T : class
    {
        private readonly T _value;
        public T Value
        {
            get
            {
                if (HasNoValue)
                    throw new InvalidOperationException();
                return _value;
            }
        }

        public bool HasValue => _value != null;
        public bool HasNoValue => !HasValue;

        private Maybe(T value)
        {
            _value = value;
        }

        public static implicit operator Maybe<T>(T value)
        {
            return new Maybe<T>(value);
        }

        public static bool operator ==(Maybe<T> maybe, T value)
        {
            if (maybe.HasNoValue)
                return false;
            return maybe.Value == value;
        }

        public static bool operator !=(Maybe<T> maybe, T value)
        {
            return !(maybe == value);
        }

        public static bool operator ==(Maybe<T> first, Maybe<T> second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Maybe<T> first, Maybe<T> second)
        {
            return !(first == second);
        }

        public bool Equals(Maybe<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
