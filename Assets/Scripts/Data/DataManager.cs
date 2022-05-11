using Data.Items;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Data
{
    public class DataManager : Singleton<DataManager>
    {
        [SerializeField] private Library library;

        public string labId;

        public List<BaseItem> GetBooksList()
        {
            List<BookItem> books = new List<BookItem>();
            foreach(var book in library.bookItems)
            {
                List<LabItem> labs = new List<LabItem>();
                foreach (var lab in book.LabItems) labs.Add(new LabItem(lab.Title, lab.LevelId));

                books.Add(new BookItem(book.Title, book.Description, book.Icon, labs.ToList<BaseItem>()));
            }
            return books.ToList<BaseItem>();
        }
    }

    [System.Serializable, CreateAssetMenu(fileName = "Library")]
    public class Library : ScriptableObject
    {
        public List<Book> bookItems;
    }

    [System.Serializable]
    public struct Lab
    {
        public string Title;
        public string LevelId;
    }
    [System.Serializable]
    public struct Book
    {
        public string Title;
        public string Description;
        public Sprite Icon;
        public List<Lab> LabItems;
    }
}
