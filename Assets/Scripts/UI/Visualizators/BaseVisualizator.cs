using System;
using UnityEngine;

namespace UI.Visualizators
{
    public abstract class BaseVisualizator<T> : MonoBehaviour
    {
        public Action<BaseVisualizator<T>> OnItemChoise;
        private T item;

        public virtual void UpdateItem(T _item)
        {
            item = _item;
        }

        public T Item => item;
    }
}
