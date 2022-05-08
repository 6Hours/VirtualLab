using Data.Items;
using System.Collections;
using System.Collections.Generic;
using UI.Screens;
using UnityEngine;

namespace UI
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private ListScreen booksListScreen;
        [SerializeField] private ListScreen labsListScreen;
        private
        // Start is called before the first frame update
        void Start()
        {
            booksListScreen.Initialize();
            labsListScreen.Initialize();
            booksListScreen.OnItemClick += OnBookClick;
            labsListScreen.OnItemClick += OnLabClick;
        }

        private void OnBookClick(BaseItem item)
        {

        }

        private void OnLabClick(BaseItem item)
        {

        }
    }
}
