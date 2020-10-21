using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gun;

    public float bulletSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = Instantiate(bullet, gun.transform.position, gun.transform.rotation);

            newBullet.GetComponent<Rigidbody2D>().velocity = gun.transform.right * bulletSpeed;
        }
    }
}
