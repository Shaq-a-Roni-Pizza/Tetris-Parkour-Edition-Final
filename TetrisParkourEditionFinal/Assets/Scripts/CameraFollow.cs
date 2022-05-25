using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform targetFollow;

    void FixedUpdate ()
    {
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(targetFollow.position.y, 0f, 40f),
            transform.position.z);
        
    }




}
    

