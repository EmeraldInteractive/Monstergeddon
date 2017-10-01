using UnityEngine;
using Assets.Scripts.UI;

namespace Assets.Scripts.Player
{
    public class Health : MonoBehaviour
    {
        [SerializeField] int MaxHealth;
        int CurrentHealth;

        private void Start()
        {
            CurrentHealth = MaxHealth;
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;

            //UpdateHealthUI.updateHealthUI.CurrentHealth -= damage;
        }
    }
}