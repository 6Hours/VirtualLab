using Data.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Visualizators.Items
{
    public class LabItemVisualizator : BaseItemVisualizator<LabItem>
    {
        [SerializeField] private Button button;
        [SerializeField] private Text titleText;

        private void Start()
        {
            button.onClick.AddListener(() => OnItemChoise?.Invoke(this));
        }
        public override void UpdateItem(LabItem _item)
        {
            base.UpdateItem(_item);
            titleText.text = Item.Title;
        }
    }
}
