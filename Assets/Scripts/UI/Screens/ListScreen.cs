using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UI.Screens
{
    public class ListScreen : BaseScreen
    {
        [SerializeField] private GameObject listContainer;
        [SerializeField] private GameObject listElementPrefab;
        //[SerializeField] private List<>

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
            //for(var i = 0; i < Mathf.Max(); i++)
        }
    }
}
