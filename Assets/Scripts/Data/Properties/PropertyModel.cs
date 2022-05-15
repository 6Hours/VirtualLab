using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Property
{
    public abstract class PropertyModel
    {
        public object MinValue;
        public object ValueSpace;
        public System.Action<object> OnValueChanged;

        private object _value;

        public object Value
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

        protected abstract object ClampValue(object value);
    }
}
