using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class UpdatePointsUI : MonoBehaviour
    {
        [HideInInspector]public int Points;
        [SerializeField] Text pointsText;

        public static UpdatePointsUI updatePointsUI;

        void Awake()
        {
            if (updatePointsUI == null)
                updatePointsUI = this;
            else if (updatePointsUI != this)
                Destroy(gameObject);
        }

        void Start()
        {
            pointsText.text = "";
        }

        private void Reset()
        {
            pointsText = GetComponent<Text>();
        }

        void Update()
        {
            pointsText.text = "Points: " + Points;
        }
    }
}
