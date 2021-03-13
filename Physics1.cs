using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics1 : MonoBehaviour
{
    public Rigidbody rb;
   
    void FixedUpdate()
    {
        rb.AddForce(10, 10, 10);
    }
}
