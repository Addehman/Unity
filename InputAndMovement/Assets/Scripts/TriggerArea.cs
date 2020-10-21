using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int score;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Box"))
        {
            score ++;
            Debug.Log("Goal!  " + score);
        }
        
    }
}
