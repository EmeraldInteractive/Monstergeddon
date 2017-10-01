using UnityEngine;

namespace Assets.Scripts.Projectile
{
    public class CreateProjectile : MonoBehaviour
    {
        [SerializeField] GameObject Projectile;
        [SerializeField] Transform SpawnPosition;

        public void SpawnProjectile()
        {
            Instantiate(Projectile, SpawnPosition.transform.position, SpawnPosition.transform.rotation);
        }
    }
}
