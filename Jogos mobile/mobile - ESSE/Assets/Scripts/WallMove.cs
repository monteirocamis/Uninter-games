using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float wallSpeed = -10 ;
     Rigidbody rb;
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        // transform.Tanslate(Vector3.forward * -1 );
      //  rb.AddForce(Vector3.forward * wallSpeed);
        rb.velocity = Vector3.forward * wallSpeed;

        if (transform.position.z < -50)
        {
            Destroy(this.gameObject);
        }
    }
}
