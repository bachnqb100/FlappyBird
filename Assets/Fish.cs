using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    public static bool Alived;
    public static int score;

    public float force;
    public float yRange = 4.5f;


    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Alived = true;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Alived)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * force);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        
        if (transform.position.y < -yRange)
        {
            Alived = false;
        }                 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Alived = false;
    }
}
