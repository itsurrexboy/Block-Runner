using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public PlayerMovement movement;
    //public GameManager gameManager;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            

        }

    }
}
