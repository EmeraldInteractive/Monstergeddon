using UnityEngine;

namespace Assets.Scripts.Projectile
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] Rigidbody RBody;
        [SerializeField] float Speed = 10f;

        private void Reset()
        {
            RBody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            RBody.MovePosition(transform.position + transform.forward * Speed * Time.deltaTime);
        }
    }
}
