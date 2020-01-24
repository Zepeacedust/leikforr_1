using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //sekódur á milli þess að tapa og restarta level
    public float restartDelay = 1f;
    bool GameHasEnded = false;
    public GameObject victoryui;
    //kveikja á victory ui
    public void complete(){
        victoryui.SetActive(true);
    }
    public void GameOver()
    {                        
        //passa að ekki restarta of oft
        if (GameHasEnded == false){
        Debug.Log("Game over");
        GameHasEnded = true;
        Invoke("Restart", restartDelay);
        }
    }
    void Restart() {
        //restarta current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
