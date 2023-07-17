using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    void Update()
    {
        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
