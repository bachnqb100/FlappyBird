using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seaweed : MonoBehaviour
{
    public float xRange = -8.5f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < xRange)
        {
            Destroy(gameObject);
        }
    }
}
