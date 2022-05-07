using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.Screens
{
    public abstract class BaseScreen
    {
        [SerializeField] protected GameObject screenRoot;

        public abstract void Initialize();
        
        public virtual void Show()
        {
            screenRoot.SetActive(true);
        }

        public virtual void Hide()
        {
            screenRoot.SetActive(false);
        }

        protected virtual void OnShowComplete()
        {

        }

        protected virtual void OnHideComplete()
        {

        }
    }
}
