using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class Countdown : MonoBehaviour
    {
        [SerializeField] float StartTimer = 60.0f;
        [SerializeField] Text timerText;

        [HideInInspector] public float CurrentTime;

        public static Countdown countDown;

        void Awake()
        {
            if (countDown == null)
                countDown = this;
            else if (countDown != this)
                Destroy(gameObject);
        }

        private void Reset()
        {
            timerText = GetComponent<Text>();
        }

        void Start()
        {
            CurrentTime = StartTimer;
            timerText.text = "Time: " + StartTimer;
        }

        void FixedUpdate()
        {
            if (CurrentTime <= 0)
            {
                CurrentTime = 0;
                timerText.text = "0";
            }
            else
            {
                CurrentTime -= Time.deltaTime;
                timerText.text = "Time: " + (int)CurrentTime;
            }
        }
    }
}
