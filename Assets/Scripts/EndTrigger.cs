
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement movement;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        movement.enabled = false;
    }


}
