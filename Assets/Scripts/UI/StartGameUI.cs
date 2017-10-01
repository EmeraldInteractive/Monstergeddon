using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts.UI
{
    public class StartGameUI : MonoBehaviour
    {
        [SerializeField] string LevelName;

        [SerializeField] GameObject LoadingScreen;
        [SerializeField] Slider LoadingBar;
        [SerializeField] Text ProgressText;

        public void StartGame()
        {
            LoadingScreen.SetActive(true);
            StartCoroutine(_LoadAsynchronously(LevelName));
        }


        private void Reset()
        {
            LoadingScreen = GameObject.Find("LoadingScreen").GetComponent<GameObject>();
            LoadingBar = GameObject.Find("LoadingBar").GetComponent<Slider>();
            ProgressText = GameObject.Find("ProgressText").GetComponent<Text>();
        }

        IEnumerator _LoadAsynchronously (string sceneName)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / .9f);

                LoadingBar.value = progress;
                ProgressText.text = progress * 100f + "%";

                yield return null;
            }
        }
    }
}
