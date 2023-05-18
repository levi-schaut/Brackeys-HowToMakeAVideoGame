using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            gameManager.WinGame();
        }
    }
}
