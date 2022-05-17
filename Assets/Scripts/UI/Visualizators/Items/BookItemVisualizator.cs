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
        [SerializeField] private Button openLink;
        [SerializeField] private Image icon;
        [SerializeField] private Text titleText;

        private void Start()
        {
            button.onClick.AddListener(() => OnItemChoise?.Invoke(this));
            openLink.onClick.AddListener(() => OpenLink());
        }
        public override void UpdateItem(BookItem _item)
        {
            base.UpdateItem(_item);
            titleText.text = Item.Title;
            icon.sprite = Item.Icon;
        }
        private void OpenLink()
        {
            GUIUtility.systemCopyBuffer = Item.Link;
        }
    }
}
