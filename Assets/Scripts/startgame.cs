using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public void restart()
    {
//      byrja á leiknum
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
