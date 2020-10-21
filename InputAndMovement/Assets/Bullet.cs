using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
        // add effect or explosion.
    }
}
