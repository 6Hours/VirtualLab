using Data.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Visualizators.Items
{
    public class BookItemVisualizator : BaseItemVisualizator<BookItem>
    {
        [SerializeField] private Button button;
        [SerializeField] private Image icon;
        [SerializeField] private Text titleText;
        [SerializeField] private Text descriptionText;

        private void Start()
        {
            button.onClick.AddListener(() => OnItemChoise?.Invoke(this));
        }
        public override void UpdateItem(BookItem _item)
        {
            base.UpdateItem(_item);
            titleText.text = Item.Title;
            descriptionText.text = Item.Description;
            icon.sprite = Item.Icon;
        }
    }
}
