using Data.Items;
using System.Collections;
using System.Collections.Generic;
using UI.Visualizators.Items;
using UnityEngine;


namespace UI.Screens
{
    [RequireComponent(typeof(CanvasGroup))]
    public class ListScreen : BaseScreen
    {    
        [SerializeField] private GameObject listContainer;
        [SerializeField] private GameObject listElementPrefab;
        [SerializeField] private List<BaseItemVisualizator<BaseItem>> visualizators;

        public System.Action<object> OnItemClick;

        public override void Initialize()
        {

        }
        public override void Show()
        {
            base.Show();

        }

        public override void Hide()
        {

        }

        protected override void OnShowComplete()
        {

        }

        protected override void OnHideComplete()
        {
            base.Hide();
        }

        public void GenerateList(List<object> list)
        {
            for(var i = 0; i < Mathf.Max(list.Count, visualizators.Count); i++)
            {
                
            }
        }
    }
}
