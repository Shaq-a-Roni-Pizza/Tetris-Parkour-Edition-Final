using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackForwardMovement : MonoBehaviour
{

    public float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 22), transform.position.y, transform.position.z);
    }
}
