using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scooch : MonoBehaviour
{   
    public float fasts = 2000f;
    public float sideFast = 500f;
    public Rigidbody rb;
    void Update()
    {
        //fara áfram 
        rb.AddForce(0,0,fasts * Time.deltaTime);
        //beygja
        if (Input.GetKey("d")) {
            rb.AddForce(sideFast * Time.deltaTime,0,0, ForceMode.VelocityChange);
        } else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideFast * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1) {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
