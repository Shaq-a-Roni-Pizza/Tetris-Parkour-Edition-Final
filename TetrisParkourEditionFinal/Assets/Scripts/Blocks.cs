using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    private float previousTime;
    public float fallTime = 0.8f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - previousTime > fallTime)
        {
            transform.position += new Vector3(0, -1, 0);
            previousTime = Time.time;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.GameObject.name == "ground")
        {
            Debug.Log("CCollision Detected");
        }
    }
}
