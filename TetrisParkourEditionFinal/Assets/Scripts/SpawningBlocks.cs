using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBlocks : MonoBehaviour
{
    public GameObject block1, block2, block3, block4, block5, block6, block7;
    public float spawnRate = 7f;
    float nextSpawn = 0f;
    int whatToSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 6);

            switch (whatToSpawn)
            {
                case 1: 
                    Instantiate(block1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(block2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(block3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(block4, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(block5, transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(block6, transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(block7, transform.position, Quaternion.identity);
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }
    }
}
