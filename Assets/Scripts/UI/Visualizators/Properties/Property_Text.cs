using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Visualizators.Properties
{
    [System.Serializable]
    public class Property_Text : BasePropertyVisualizator
    {
        [SerializeField] private Text textElement;
        protected override void Start()
        {
            base.Start();
            property.OnValueChanged += OnValueChanged;
        }

        private void OnValueChanged(object value)
        {
            textElement.text = value.ToString();
        }
    }
}
