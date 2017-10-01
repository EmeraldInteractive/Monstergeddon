using UnityEngine;

namespace Assets.Scripts.Camera
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] Transform target;            //target to follow
        [SerializeField] float smoothFollow = 5f;     //How smooth the camera follows

        Vector3 offset;

        void Start()
        {
            offset = transform.position - target.position;
        }

        void FixedUpdate()
        {
            Vector3 targetCamPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothFollow * Time.deltaTime);
        }
    }
}
