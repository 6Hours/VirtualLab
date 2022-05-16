using Data.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ProcessController : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        [SerializeField] private Button stopButton;
        [SerializeField] private Button homeButton;

        void Start()
        {
            playButton.onClick.AddListener(OnPlayClick);
            stopButton.onClick.AddListener(OnStopClick);
            homeButton.onClick.AddListener(OnHomeClick);
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
        private void OnHomeClick()
        {
            SceneManager.LoadScene(0);
        }
    }
}