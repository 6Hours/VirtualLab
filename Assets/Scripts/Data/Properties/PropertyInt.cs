using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Property
{
    public class PropertyInt : PropertyModel
    {
        public PropertyInt(int min, int space)
        {
            MinValue = min;
            ValueSpace = space;
        }
        protected override object ClampValue(object value)
        {
            return Mathf.Clamp((int)value, (int)MinValue, (int)MinValue + (int)ValueSpace);
        }
    }
}
