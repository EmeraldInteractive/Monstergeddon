using UnityEngine;

namespace Assets.Scripts.Environment
{
    public class BuildingPartPhysics : MonoBehaviour
    {
        [SerializeField ]Rigidbody rb;

        private void Reset()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if(rb.velocity.x >= 0.1 || rb.velocity.y >= 0.1 || rb.velocity.z >= 0.1)
            {
                rb.useGravity = true;
            }
        }
    }
}