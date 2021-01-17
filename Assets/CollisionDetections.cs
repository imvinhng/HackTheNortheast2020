using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetections : MonoBehaviour
    {
    public PlayerMovement movement;
     public void OnTriggerEnter(Collider other)
    {   if (other.GetComponent<Collider>().tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameMana>().EndGame();


        }
    }
      
        




}


