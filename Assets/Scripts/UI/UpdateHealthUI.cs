using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class UpdateHealthUI : MonoBehaviour
    {
        public static UpdateHealthUI updateHealthUI;

        void Awake()
        {
            if (updateHealthUI == null)
                updateHealthUI = this;
            else if (updateHealthUI != this)
                Destroy(gameObject);
        }

        [SerializeField] Slider HealthSlider;
        public int MaxHealth = 100;
        [HideInInspector] public int CurrentHealth;

        private void Reset()
        {
            HealthSlider = GetComponent<Slider>();
        }

        private void Start()
        {
            CurrentHealth = MaxHealth;
        }

        private void FixedUpdate()
        {
            HealthSlider.value = CurrentHealth;
        }
    }
}
