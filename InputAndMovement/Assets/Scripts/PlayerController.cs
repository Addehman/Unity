using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movementExtra = new Vector3(x, y, 0);

        if (movementExtra.sqrMagnitude > 1)
        {
            movementExtra = movementExtra.normalized;
        }
        Vector3 movement = movementExtra * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}
