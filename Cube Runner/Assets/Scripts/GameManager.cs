using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        if (isGameEnded)
        {
            return;
        }
        isGameEnded = true;
        Debug.Log("Game over");
        Invoke("Restart", restartDelay);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
