using Data.Property;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers.Property
{
    [System.Serializable]
    public abstract class BasePropertyController : MonoBehaviour
    {
        [SerializeField] protected string propertyKey;
        [SerializeField] protected Vector3 scaleMultiplier;

        protected PropertyModel property;

        private void Start()
        {
            property = FindObjectOfType<MainController>().GetModel().GetProperty(propertyKey);
            property.OnValueChanged += OnValueChanged;
            OnValueChanged(property.Value);
        }

        protected abstract void OnValueChanged(object value);
    }
}
