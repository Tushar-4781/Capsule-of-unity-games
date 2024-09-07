using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Score.CurrentScore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
