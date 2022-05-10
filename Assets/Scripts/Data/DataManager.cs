using Data.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class DataManager : Singleton<DataManager>
    {
        [SerializeField] private Library library;

        public List<BookItem> GetBooksList()
        {
            return library.bookItems;
        }
    }

    [System.Serializable, CreateAssetMenu(fileName = "Library")]
    public class Library : ScriptableObject
    {
        public List<BookItem> bookItems;
    }

}
