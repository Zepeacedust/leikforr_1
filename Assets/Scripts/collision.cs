using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{   
    //scooch er movement script hjá playernum
    public Scooch scooch;
    
    void OnCollisionEnter(Collision collisionInfo) {
        //Ekki colida við gólfið
        if (collisionInfo.collider.tag == "obstacle"){
            //slökkva á scooch og enda leikinn.
            scooch.enabled =false;
            FindObjectOfType<GameManager>().GameOver();
            }

    }
}
