using UnityEngine;


public class CamerFollow : MonoBehaviour
{
    [SerializeField]
    private Transform targetFollow;
    

    void Update ()
    {
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(targetFollow.position.y, 0f, 10f),
            transform.position.z);
        
    }




}
    

