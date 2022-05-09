using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Items
{
    public class LabItem : BaseItem
    {
        public string Title { get; private set; }

        public string LevelId { get; private set; }

        public LabItem(string _title, string _levelId)
        {
            Title = _title;
            LevelId = _levelId;
        }
    }
}