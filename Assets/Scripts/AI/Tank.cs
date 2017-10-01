using UnityEngine;
using Assets.Scripts.Projectile;

namespace Assets.Scripts.AI
{
    public class Tank : MonoBehaviour
    {
        CreateProjectile Missle;

        [SerializeField] AudioSource Source;

        [SerializeField] int Speed = 6;

        bool shouldMove;
        bool canFire;

        [SerializeField] float AttackDelay = 2.75f;
        float AttackRate;

        private void Start()
        {
            Missle = GetComponent<CreateProjectile>();
        }

        private void FixedUpdate()
        {
            //if (shouldMove)
            //    transform.Translate(Speed * Time.deltaTime, 0, 0);

            if (canFire)
            {
                if (Time.time >= AttackRate)
                {
                    AttackRate = Time.time + AttackDelay;
                    Source.Play();
                    Missle.SpawnProjectile();
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                shouldMove = true;
                canFire = true;
            }

            if (other.gameObject.tag == "Fireball")
                Destroy(gameObject);
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                shouldMove = false;
                canFire = false;
            }
        }
    }
}
