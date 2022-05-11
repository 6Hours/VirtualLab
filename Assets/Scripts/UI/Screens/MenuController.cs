using Data.Items;
using System.Collections;
using System.Collections.Generic;
using UI.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private ListScreen booksListScreen;
        [SerializeField] private ListScreen labsListScreen;
        [SerializeField] private Button backButton;
        // Start is called before the first frame update
        void Start()
        {
            booksListScreen.Initialize();
            labsListScreen.Initialize();
            booksListScreen.OnItemClick += OnBookClick;
            labsListScreen.OnItemClick += OnLabClick;
            booksListScreen.GenerateList(Data.DataManager.Instance.GetBooksList());
        }

        private void OnBookClick(BaseItem item)
        {
            booksListScreen.Hide();
            labsListScreen.Show();
            labsListScreen.GenerateList((item as BookItem).LabItems);
        }

        private void OnLabClick(BaseItem item)
        {

        }

        private void UpdateBookList()
        {


            booksListScreen.GenerateList(null);
        }
    }
}
