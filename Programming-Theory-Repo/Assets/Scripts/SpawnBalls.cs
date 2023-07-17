using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    [SerializeField] GameObject[] balls;
    private int index;
    void Start()
    {
        InvokeRepeating("Spawn", 1, 4);
    }

    void Spawn()
    {
        index = Random.Range(0, balls.Length);
        Vector3 position = new Vector3(Random.Range(-50,50), Random.Range(-13, 13), 150);
        Instantiate(balls[index], position, balls[index].transform.rotation);
    }
}
