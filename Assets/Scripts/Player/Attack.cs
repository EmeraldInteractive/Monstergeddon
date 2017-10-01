using UnityEngine;
using Assets.Scripts.Projectile;

namespace Assets.Scripts.Player
{
    public class Attack : MonoBehaviour
    {
        CreateProjectile Fireball;
        [SerializeField] AudioSource Source;

        [SerializeField] float AttackDelay = 0.75f;
        float AttackRate;

        private void Start()
        {
            Fireball = GetComponent<CreateProjectile>();
        }

        void Update()
        {
            if (Input.GetButtonUp("Fire1"))
            {
                if (Time.time >= AttackRate)
                {
                    AttackRate = Time.time + AttackDelay;
                    Fireball.SpawnProjectile();
                    Source.Play();
                }
            }
        }
    }
}
