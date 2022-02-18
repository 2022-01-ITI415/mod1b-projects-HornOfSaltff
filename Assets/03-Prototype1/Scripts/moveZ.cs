using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveZ : MonoBehaviour
{
    

    // Speed at which the AppleTree moves

    public float        speed = 8f;


                   
    // Distance where AppleTree turns around

    public float        leftAndRightEdge = 4f;


                   
    // Chance that the AppleTree will change directions

    public float        chanceToChangeDirections = 0.1f;

	// Before rendering each frame..
	void Update () 
	{
		// Rotate the game object that this script is attached to by 15 in the X axis,
		// 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
		// rather than per frame.
		// Basic Movement

        Vector3 pos = transform.position;                  // b

        //pos.x += speed * Time.deltaTime;                   // c

		pos.z += speed * Time.deltaTime;
        transform.position = pos;                          // d



        // Changing Direction
        
	   if ( pos.z < -leftAndRightEdge ) {                             // a

           speed = Mathf.Abs(speed); // Move right                    // b

       } else if ( pos.z > leftAndRightEdge ) {                       // c

           speed = -Mathf.Abs(speed); // Move left                    // c

       }
       //if ( pos.x < -leftAndRightEdge ) {                             // a

        //   speed = Mathf.Abs(speed); // Move right                    // b

       //} else if ( pos.x > leftAndRightEdge ) {                       // c

        //   speed = -Mathf.Abs(speed); // Move left                    // c

      // }
	   
	}
	void FixedUpdate() {

        // Changing Direction Randomly is now time-based because of FixedUpdate()

        if ( Random.value < chanceToChangeDirections ) {                     // b

            speed *= -1; // Change direction

        }

    }
}
