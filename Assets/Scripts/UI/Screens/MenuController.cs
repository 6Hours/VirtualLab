using Data.Items;
using System.Collections;
using System.Collections.Generic;
using UI.Screens;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UI
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private BooksScreen booksScreen;
        [SerializeField] private LabsScreen labsScreen;
        [SerializeField] private Button backButton;
        // Start is called before the first frame update
        void Start()
        {
            booksScreen.Initialize();
            labsScreen.Initialize();
            booksScreen.OnItemClick += OnBookClick;
            labsScreen.OnItemClick += OnLabClick;

            backButton.onClick.AddListener(BackToMain);
            backButton.gameObject.SetActive(false);
            UpdateBookList();
        }

        private void OnBookClick(BaseItem item)
        {
            booksScreen.Hide();
            labsScreen.Show();
            backButton.gameObject.SetActive(true);
            labsScreen.GenerateList((item as BookItem).LabItems);
        }

        private void OnLabClick(BaseItem item)
        {
            Data.DataManager.Instance.labId = (item as LabItem).LevelId;
            SceneManager.LoadScene(1);
        }

        private void UpdateBookList()
        {
            booksScreen.GenerateList(Data.DataManager.Instance.GetBooksList());
        }

        private void BackToMain()
        {
            backButton.gameObject.SetActive(false);
            booksScreen.Show();
            labsScreen.Hide();
        }
    }
}
