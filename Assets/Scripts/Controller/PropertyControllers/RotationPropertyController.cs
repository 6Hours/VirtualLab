using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers.Property
{
    [System.Serializable]
    public class RotationPropertyController : BasePropertyController
    {
        protected override void OnValueChanged(object value)
        {
            transform.rotation = Quaternion.Euler(scaleMultiplier * (float)value);
        }
    }
}
