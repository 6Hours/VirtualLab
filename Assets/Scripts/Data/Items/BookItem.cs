using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Items
{
    [System.Serializable]
    public class BookItem : BaseItem
    {
        public string Title { get; private set; }
        public string Link { get; private set; }
        public Sprite Icon { get; private set; }
        public List<BaseItem> LabItems { get; private set; }

        public BookItem(string _title, string _link, Sprite _icon, List<BaseItem> _labItems)
        {
            Title = _title;
            Link = _link;
            Icon = _icon;
            LabItems = _labItems;
        }
    }
}