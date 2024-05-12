using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardForce = 500f;


        
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*
        else if (Input.GetKey("space"))
        {
            rb.AddForce(0, upwardForce * Time.deltaTime, 0); 
        }
        */

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
            
        }

    }
}
