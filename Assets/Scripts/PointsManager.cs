using Assets.Scripts.UI;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    [SerializeField] int Points = 10;

    bool canGivePoints = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Flying Building Part" || other.tag == "Fireball")
        {
            if (canGivePoints)
            {
                UpdatePointsUI.updatePointsUI.Points += Points;
                canGivePoints = false;
            }
        }
    }
}
