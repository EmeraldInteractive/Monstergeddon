using UnityEngine;

namespace Assets.Scripts.Level
{
    public class ProceduralLevelDesigner : MonoBehaviour
    {
        [Header("City Structures")]
        [SerializeField]
        GameObject[] Buildings;
        [SerializeField]
        GameObject GroundTile;

        //Building Prefabs
        [Header("Building Prefabs")]
        [Tooltip("The current building's location.")]
        [SerializeField]
        int BuildingLocation = 0;

        [Tooltip("How much space should be between buildings.")]
        [SerializeField]
        int SpaceBetweenBuildings = 2;

        [Tooltip("The current number of buildings in the scene.")]
        [SerializeField]
        int CurrentNumberOfBuildings = 0;

        [Tooltip("The max number of buildings allowed in the scene at any time.")]
        [SerializeField]
        int TotalNumberOfBuildings = 15;

        //Ground Tiles
        [Header("Ground Tiles")]
        [Tooltip("The current ground tile's location.")]
        [SerializeField]
        int GroundTileLocation = 0;

        [Tooltip("How much space should be between ground tiles.")]
        [SerializeField]
        int SpaceBetweenGroundTiles = 10;

        [Tooltip("The current number of ground tiles in the scene.")]
        [SerializeField]
        int CurrentNumberOfGroundTiles = 0;

        [Tooltip("The max number of ground tiles allowed in the scene at any time.")]
        [SerializeField]
        int TotalNumberOfGroundTiles = 10;

        //Enemies
        [Header("Enemies")]
        [SerializeField]
        GameObject[] Enemies;

        private void Start()
        {
            DrawCityLayout();
        }

        private void FixedUpdate()
        {
            //check to see the total number of buildings and redraw the city if fewer than 10 buildings exist
            if (CurrentNumberOfBuildings < TotalNumberOfBuildings)
            {
                DrawCityLayout();
                CreateNewEnemies();
                CurrentNumberOfBuildings++;
            }

            if (CurrentNumberOfGroundTiles < TotalNumberOfBuildings)
            {
                DrawGroundTile();
                CurrentNumberOfGroundTiles++;
            }
        }

        void DrawGroundTile()
        {
            CreateNewGroundTile();
            GroundTileLocation += SpaceBetweenGroundTiles;
        }

        void DrawCityLayout()
        {
            CreateNewBuilding();
            BuildingLocation += SpaceBetweenBuildings;
        }

        public void ReduceNumberOfGroundTiles()
        {
            CurrentNumberOfGroundTiles--;
        }

        public void ReduceTotalNumberOfBuildings()
        {
            CurrentNumberOfBuildings--;
        }

        void CreateNewGroundTile()
        {
            Instantiate(GroundTile, new Vector3(GroundTileLocation, 0, 0), Quaternion.identity);
        }

        void CreateNewBuilding()
        {
            int chance = GenerateRandomNumber(0, Buildings.Length);

            switch (chance)
            {
                case 0:
                    Instantiate(Buildings[0], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(Buildings[1], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Buildings[2], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Buildings[3], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Buildings[4], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(Buildings[5], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 6:
                    Instantiate(Buildings[6], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 7:
                    Instantiate(Buildings[7], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 8:
                    Instantiate(Buildings[8], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
                case 9:
                    Instantiate(Buildings[9], new Vector3(BuildingLocation, 0, 0), Quaternion.identity);
                    break;
            }
        }

        void CreateNewEnemies()
        {
            int chance = GenerateRandomNumber(1, 101);

            if (chance <= 35 )
            {
                Instantiate(Enemies[0], new Vector3(BuildingLocation, 0, -0.3f), Quaternion.identity);
            }
        }

        int GenerateRandomNumber(int min, int max)
        {
            var helper = new System.Random(System.DateTime.Now.Ticks.GetHashCode());

            int roll = helper.Next(min, max);

            return roll;
        }
    }
}
