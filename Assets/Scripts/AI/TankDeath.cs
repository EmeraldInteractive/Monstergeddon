using UnityEngine;

namespace Assets.Scripts.AI
{
    public class TankDeath : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Fireball")
                Destroy(gameObject);
        }
    }
}
