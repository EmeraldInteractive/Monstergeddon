using System;
using UnityEngine;

namespace Assets.Scripts.Projectile
{
    public class ExplosionPhysics : MonoBehaviour
    {
        [SerializeField] float Force = 5f;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag != "Player" && other.gameObject.tag != "BuildingContainer")
            {
                try
                {
                    float multiplier = other.attachedRigidbody.mass;
                    float radius = 10 * multiplier;
                    other.attachedRigidbody.AddExplosionForce(Force * multiplier, transform.position, radius, multiplier, ForceMode.Impulse);
                }
                catch (Exception ex)
                {
                    Debug.LogWarning("Uh oh");
                    Debug.LogError(ex.Message);
                }
            }
        }
    }
}
