using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Visualizators.Properties
{
    [System.Serializable]
    public class Property_InputField : BasePropertyVisualizator
    {
        [SerializeField] private InputField inputField;
        protected override void Start()
        {
            base.Start();
            inputField.onValueChanged.AddListener(OnValueChanged);
            property.OnValueChanged += OnValueChanged;
        }

        private void OnValueChanged(object value)
        {
            property.Value = value;
            inputField.SetTextWithoutNotify(value.ToString());
        }
    }
}
