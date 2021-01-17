using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   // This is saying Rigidbody=rb
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;
    // I changed this to FixedUpdate because it is smoother with Unity phisics.
    public void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime); // Adds force of 2000 on Z-axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
          FindObjectOfType<GameMana>().EndGame();
        }
    }

}