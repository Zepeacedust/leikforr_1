using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelend : MonoBehaviour
{   //trigger á enda lavelsisns til að loada næsta
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.complete();
    }
}
