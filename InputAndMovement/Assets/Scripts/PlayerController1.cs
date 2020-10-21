using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    // Floating point variable to store player's movement speed.
    public float speed;

    // Store a reference to the Rigidbody2D component required to use 2D Physics.
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Store the current horizontal input in the float moveHorizontal
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Store the current vertical input in the float moveVertical
        float moveVertical = Input.GetAxis("Vertical");

        // Use the two stored floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        movement = movement.normalized;

        // Call the AddForce function of our Rigidbody2D rb2d supplying movement
        //multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }
}
