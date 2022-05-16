using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Property
{
    public class PropertyFloat : PropertyModel
    {
        public PropertyFloat(float min, float space)
        {
            MinValue = min;
            ValueSpace = space;
        }
        protected override object ClampValue(object value)
        {
            return Mathf.Clamp((float)value, (float)MinValue, (float)MinValue + (float)ValueSpace);
        }
    }
}
