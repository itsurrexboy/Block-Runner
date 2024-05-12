using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //bool gameHasEnded = false;
    public float restartDelay = 20f;
    public GameObject completeLevelUi;
    public GameObject restartLevelUi;
    public GameObject scoreText;

    public void CompleteLevel()
    {
        Debug.Log("Game Complete!!");
        completeLevelUi.SetActive(true);
        scoreText.SetActive(false);

    }
    public void EndGame()
    {
        scoreText.SetActive(false);
        restartLevelUi.SetActive(true);
        Debug.Log("Level Failed!");
        
        //this if() used to call the Restart() after some delay automatically.
        /*
         * 
         * if (gameHasEnded == false)
        {
            gameHasEnded = true;
            
            Debug.Log("GAME OVER!!!");
            Invoke("Restart", restartDelay);
        }
        */
    }

    public void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Restart Button Clicked !!");
    }

    public void LoadNextLevel()
    {
        Debug.Log("LoadNextLevel Function is called!!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
