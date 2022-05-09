using Data.Property;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.Visualizators.Property
{
    public abstract class BasePropertyVisualizator : MonoBehaviour
    {
        [SerializeField] private string propertyKey;
        [SerializeField] private float compareMultiplier;

        private PropertyModel<object> property;

        private void Start()
        {
            property = FindObjectOfType<MainController>().GetModel().GetProperty(propertyKey);
            property.OnValueChanged += OnValueChanged;
        }

        protected abstract void OnValueChanged(object value);
    }
}
