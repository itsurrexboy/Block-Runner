
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    //This script allow the camera to follow the Player

   void Update()
    {
        
        transform.position = player.position + offset;


    }
}
