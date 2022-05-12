using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBlocks : MonoBehaviour
{
    public GameObject Tetromino;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(0f, 0f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Tetromino, whereToSpawn, Quaternion.identity);
        }
    }
}
