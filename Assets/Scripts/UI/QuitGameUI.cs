using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.UI
{
    public class QuitGameUI : MonoBehaviour
    {
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
