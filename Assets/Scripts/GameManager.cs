using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 2f;
    
    bool gameHasEnded = false;

    /* This custom method represents a game over.  It can be called by any
     * other GameObject that detects a loss condition, and it initiates a
     * game restart. */
    public void GameOver() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    // Restarts the game by reloading the currently active scene.
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
