using MovementEffects;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Environment
{
    public class CrumblingPhysics : MonoBehaviour
    {
        [Header("Building Components")]
        [SerializeField]
        Rigidbody[] RBody;
        [SerializeField] Transform[] BuildingParts;

        private void Reset()
        {
            RBody = GetComponentsInChildren<Rigidbody>();
            BuildingParts = GetComponentsInChildren<Transform>();
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" || other.tag == "Flying Building Part" || other.tag == "Fireball")
            {
                Timing.RunCoroutine(_TurnOnGravity());
            }
            else
                return;
        }

        IEnumerator<float> _TurnOnGravity()
        {
            yield return Timing.WaitForSeconds(0);
            TurnGravityOnForBuildingPart();
            ChangeTagOnBuildingPart();

            Timing.KillCoroutines();
        }

        void TurnGravityOnForBuildingPart()
        {
            for (int i = 0; i < RBody.Length; i++)
            {
                if (RBody[i] != null)
                {
                    RBody[i].useGravity = true;
                }
            }
        }

        void ChangeTagOnBuildingPart()
        {
            for (int i = 0; i < BuildingParts.Length; i++)
            {
                if (BuildingParts[i].gameObject.tag != null)
                    BuildingParts[i].gameObject.tag = "Flying Building Part";
                else
                    return;
            }
        }
    }
}
