using Data.Property;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.Visualizators.Properties
{
    [System.Serializable]
    public abstract class BasePropertyVisualizator : MonoBehaviour
    {
        [SerializeField] protected string propertyKey;

        protected PropertyModel property;

        protected virtual void Start()
        {
            property = FindObjectOfType<MainController>().GetModel().GetProperty(propertyKey);
        }
    }
}
