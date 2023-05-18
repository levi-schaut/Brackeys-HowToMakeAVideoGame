using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    /* This custom method represents a game over.  It can be called by any
     * other GameObject that detects a loss condition, and it initiates a
     * game restart. */
    public void GameOver() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
        }
    }
}
