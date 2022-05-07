using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Property
{
    public abstract class PropertyModel<T>
    {
        public T MinValue;
        public T ValueSpace;
        public System.Action<T> OnValueChanged;

        private T _value;

        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = ClampValue(value);
                OnValueChanged?.Invoke(_value);
            }
        }

        protected abstract T ClampValue(T value);
    }
}
