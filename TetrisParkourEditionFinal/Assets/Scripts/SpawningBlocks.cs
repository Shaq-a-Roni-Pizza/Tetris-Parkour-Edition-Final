using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBlocks : MonoBehaviour
{
    public GameObject[] Tetrominoes;
    float randX;
    Vector2 wheretoSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        NewTetromino();
    }

    public void NewTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }
}
