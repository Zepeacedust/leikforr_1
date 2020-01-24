using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasecam : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    
    void Update()
    {
        //fylgja player offset um offest
        transform.position = player.position + offset;
    }
}
