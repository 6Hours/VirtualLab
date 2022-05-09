using System.Collections;
using System.Collections.Generic;
using UI.Visualizators.Property;
using UnityEngine;

namespace Controllers.Visualizator
{
    public class PositionPropertyVisualizator : BasePropertyVisualizator
    {
        [SerializeField] private Vector3 offset;
        [SerializeField] private Vector3 positionMultiplier;
        protected override void OnValueChanged(object value)
        {
            //transform.position = 
        }
    }
}
