using UnityEngine;

namespace Assets.Scripts.Player
{
    public class DestroyPlayerProjectile : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Floor" || other.gameObject.tag == "BuildingPart")
            {
                Destroy(gameObject, 0.5f);
            }
        }
    }
}
