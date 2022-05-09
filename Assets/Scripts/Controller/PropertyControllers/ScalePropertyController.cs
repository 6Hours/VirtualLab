using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers.Property
{
    [System.Serializable]
    public class ScalePropertyController : BasePropertyController
    {
        protected override void OnValueChanged(object value)
        {
            transform.localScale = Vector3.one + scaleMultiplier * (float) value;
        }
    }
}
