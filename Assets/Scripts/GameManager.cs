using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        Debug.Log("LEVEL Completed!");
        completeLevelUI.SetActive(true);
    }

	public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
