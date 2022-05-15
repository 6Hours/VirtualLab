using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Visualizators.Properties
{
    [System.Serializable]
    public class Property_Buttons : BasePropertyVisualizator
    {
        [SerializeField] private Button plusBtn;
        [SerializeField] private Button minusBtn;
        protected override void Start()
        {
            base.Start();
            plusBtn.onClick.AddListener(() => AddValue(1));
            minusBtn.onClick.AddListener(() => AddValue(-1));
        }

        private void AddValue(int addValue)
        {
            property.Value = (int)property.Value + addValue;
        }
    }
}
