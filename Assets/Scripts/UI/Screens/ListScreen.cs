using Data.Items;
using System.Collections;
using System.Collections.Generic;
using UI.Visualizators.Items;
using UnityEngine;
using DG.Tweening;

namespace UI.Screens
{
    [System.Serializable]
    public class ListScreen : BaseScreen
    {    
        [SerializeField] private RectTransform listContainer;
        [SerializeField] private GameObject listElementPrefab;
        [SerializeField] private List<BaseItemVisualizator<BaseItem>> visualizators;
        [SerializeField] private CanvasGroup canvasGroup;

        public System.Action<BaseItem> OnItemClick;

        public override void Initialize()
        {

        }
        public override void Show()
        {
            base.Show();
            DOTween.To(() => 0f, (v) =>
            {
                canvasGroup.alpha = v;
                screenRoot.localScale = Vector2.one * Mathf.Clamp(v + 0.5f, 0f, 1f);
            }, 1f, 1f).OnComplete(OnShowComplete);
        }

        public override void Hide()
        {
            DOTween.To(() => 1f, (v) =>
            {
                canvasGroup.alpha = v;
                screenRoot.localScale = Vector2.one * Mathf.Clamp(v + 0.5f, 0f, 1f);
            }, 0f, 1f).OnComplete(OnHideComplete);
        }

        protected override void OnShowComplete()
        {

        }

        protected override void OnHideComplete()
        {
            base.Hide();
        }

        public void GenerateList(List<BaseItem> list)
        {
            for (var i = 0; i < Mathf.Max(list.Count, visualizators.Count); i++)
            {
                if (i < visualizators.Count)
                {
                    visualizators[i].gameObject.SetActive(i < list.Count);
                    if (i < list.Count)
                        visualizators[i].UpdateItem(list[i]);
                }
                else
                {
                    visualizators.Add(Object.Instantiate(listElementPrefab, listContainer).GetComponent<BaseItemVisualizator<BaseItem>>());
                    visualizators[i].UpdateItem(list[i]);
                    visualizators[i].OnItemChoise += OnClick;
                }
            }
        }
        private void OnClick(BaseItemVisualizator<BaseItem> visualizator)
        {
            OnItemClick?.Invoke(visualizator.Item);
        }
    }
}
