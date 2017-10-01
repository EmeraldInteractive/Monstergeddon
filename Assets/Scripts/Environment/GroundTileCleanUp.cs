using UnityEngine;
using Assets.Scripts.Level;

namespace Assets.Scripts.Environment
{
    public class GroundTileCleanUp : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "LevelManager")
            {
                other.GetComponent<ClearAssetsFromLevel>().ClearGroundTile();

                DestroyGroundTile();
            }
        }

        public void DestroyGroundTile()
        {
            Destroy(this.gameObject);
        }
    }
}
