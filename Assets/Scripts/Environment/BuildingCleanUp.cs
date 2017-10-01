using UnityEngine;
using Assets.Scripts.Level;

namespace Assets.Scripts.Environment
{
    public class BuildingCleanUp : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "LevelManager")
            {
                other.GetComponent<ClearAssetsFromLevel>().ClearBuilding();

                DestroyBuilding();
            }
        }

        public void DestroyBuilding()
        {
            Destroy(this.gameObject);
        }
    }

}
