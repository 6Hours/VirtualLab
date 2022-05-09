using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers.Property
{
    [System.Serializable]
    public class PositionPropertyController : BasePropertyController
    {
        [SerializeField] private Vector3 positionMoveMultiplier;

        protected override void OnValueChanged(object value)
        {
            var tempScale = scaleMultiplier;
            tempScale.Scale(transform.position);
            transform.position = (positionMoveMultiplier * (float)value + tempScale); 
        }
    }
}
