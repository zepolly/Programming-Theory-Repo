using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    private void Update()
    {
        if (transform.position.z > 150)
        {
            Destroy(gameObject);
        }
    }
}
