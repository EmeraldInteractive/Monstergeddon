using UnityEngine;
using Assets.Scripts.Projectile;

namespace Assets.Scripts.Player
{
    public class Attack : MonoBehaviour
    {
        CreateProjectile Fireball;

        private void Start()
        {
            Fireball = GetComponent<CreateProjectile>();
        }

        void Update()
        {
            if(Input.GetButtonUp("Fire1"))
            {
                Fireball.SpawnProjectile();
            }
        }
    }
}
