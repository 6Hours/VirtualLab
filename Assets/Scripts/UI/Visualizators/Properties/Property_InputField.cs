using System;
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
            inputField.onEndEdit.AddListener(OnValueChanged);
            inputField.SetTextWithoutNotify(property.Value.ToString());
        }

        private void OnValueChanged(object value)
        {
            property.Value = (float)Convert.ToDouble(value);
            inputField.SetTextWithoutNotify(value.ToString());
        }
    }
}
