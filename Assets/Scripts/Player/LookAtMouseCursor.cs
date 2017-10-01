using UnityEngine;

namespace Assets.Scripts.Player
{
    public class LookAtMouseCursor : MonoBehaviour
    {
        public float Speed = 20.0f;


        void LateUpdate()
        {
            transform.Rotate(new Vector3(0, 0, -Input.GetAxis("Mouse X")) * Time.deltaTime * Speed);
        }
    }
}
