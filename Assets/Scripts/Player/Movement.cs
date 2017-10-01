using UnityEngine;

namespace Assets.Scripts.Player
{
    [System.Serializable]
    public class Boundary
    {
        public float xMin, xMax, yMin, yMax;
    }

    public class Movement : MonoBehaviour
    {
        [SerializeField] Rigidbody rigidbody;
        [SerializeField] float Speed;
        [SerializeField] Boundary boundary;

        private void Reset()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

            rigidbody.velocity = movement * Speed;


            rigidbody.position = new Vector3(
                Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax),
                Mathf.Clamp(rigidbody.position.y, boundary.yMin, boundary.yMax),
                0.0f
            );

            IncreaseHorizontalBoundary();
        }

        //Increase Boundary's xMin by the horizontal axis
        void IncreaseHorizontalBoundary()
        {
            boundary.xMin += boundary.xMin;
            boundary.xMax += boundary.xMax;
        }
    }
}
