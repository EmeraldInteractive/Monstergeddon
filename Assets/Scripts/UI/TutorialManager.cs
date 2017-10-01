using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class TutorialManager : MonoBehaviour
    {
        [SerializeField] GameObject TutorialObject;
        [SerializeField] Text TutorialText;
        bool isOn = true;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                if (isOn)
                {
                    Off();
                    TutorialText.text = "Press Esc to activate Tutorial";
                }
               else
                {
                    On();
                    TutorialText.text = "Press Esc to close";
                }
            }
        }

        public void Off()
        {
            isOn = false;
            TutorialObject.SetActive(false);
        }

        public void On()
        {
            isOn = true;
            TutorialObject.SetActive(true);
        }
    }
}
