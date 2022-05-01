using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyFloat : PropertyModel<float>
{
    protected override float ClampValue(float value)
    {
        return Mathf.Clamp(value, MinValue, MinValue + ValueSpace);
    }
}
