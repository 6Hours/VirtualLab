using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers.Property
{
    [System.Serializable]
    public class ObjectPropertyController : BasePropertyController
    {
        [SerializeField] private GameObject[] objects; 
        protected override void OnValueChanged(object value)
        {
            for(var i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(i == (int)value);
            }
        }
    }
}
