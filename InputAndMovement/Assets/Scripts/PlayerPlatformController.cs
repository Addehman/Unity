using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformController : MonoBehaviour
{
    public float speed;
    public float jumpPower = 10;

    Rigidbody2D rb2d;
    Vector2 movement = new Vector2();

    bool grounded = false;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        movement = new Vector2(x * speed, rb2d.velocity.y);

        if ((Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow)) && grounded)
        {
            //Jump with impulse
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

            //Jump with velocity
            //rb2d.velocity = new Vector2(rb2d.velocity.y, jumpPower);
        }
    }
    
    void FixedUpdate()
    {
        rb2d.velocity = movement;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        grounded = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        grounded = false;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        grounded = true;
    }
}
