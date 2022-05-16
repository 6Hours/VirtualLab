using Data.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ProcessController : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        [SerializeField] private Button stopButton;

        void Start()
        {
            playButton.onClick.AddListener(OnPlayClick);
            stopButton.onClick.AddListener(OnStopClick);
        }

        private void OnPlayClick()
        {
            FindObjectOfType<BaseModel>().PlayModel(1f);
            stopButton.gameObject.SetActive(true);
            playButton.gameObject.SetActive(false);
        }
        private void OnStopClick()
        {
            FindObjectOfType<BaseModel>().Stop();
            playButton.gameObject.SetActive(true);
            stopButton.gameObject.SetActive(false);
        }
    }
}