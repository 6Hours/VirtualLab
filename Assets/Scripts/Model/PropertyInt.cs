using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyInt : PropertyModel<int>
{
    protected override int ClampValue(int value)
    {
        return Mathf.Clamp(value, MinValue, MinValue + ValueSpace);
    }
}
