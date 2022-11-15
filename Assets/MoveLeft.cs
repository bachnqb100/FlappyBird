using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Fish.Alived)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

}
