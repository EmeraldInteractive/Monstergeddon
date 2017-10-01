using UnityEngine;
using Assets.Scripts.Player;

namespace Assets.Scripts.AI
{
    public class DamagePlayerHealth : MonoBehaviour
    {
        [SerializeField] int Damage = 2;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Player")
            {
                other.GetComponent<Health>().TakeDamage(Damage);
                Destroy(gameObject, 0.1f);
            }
        }
    }
}
