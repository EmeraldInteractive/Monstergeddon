using UnityEngine;

namespace Assets.Scripts.Level
{
    public class ClearAssetsFromLevel : MonoBehaviour
    {
        ProceduralLevelDesigner LevelDesigner;

        private void Start()
        {
            LevelDesigner = GetComponent<ProceduralLevelDesigner>();
        }

        public void ClearBuilding()
        {
            LevelDesigner.ReduceTotalNumberOfBuildings();
        }

        public void ClearGroundTile()
        {
            LevelDesigner.ReduceNumberOfGroundTiles();
        }
    }
}
