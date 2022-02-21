using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Speed at which the AppleTree moves

    public float        speed = 1f;


                   
    // Distance where AppleTree turns around

    public float        leftAndRightEdge = 10f;


                   
    // Chance that the AppleTree will change directions

    public float        chanceToChangeDirections = 0.1f;

	// Before rendering each frame..
	void Update () 
	{
		
		transform.Rotate (new Vector3 (0, 20, 0) * Time.deltaTime);
		// Basic Movement

        
	   
	}

}