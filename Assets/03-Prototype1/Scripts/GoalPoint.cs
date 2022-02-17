using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalPoint : MonoBehaviour
{
    void OnTriggerEnter( Collider other ) {

        // When the trigger is hit by something

        // Check to see if it's a Projectile

        if ( other.gameObject.tag == "Player" ) {

            // If so, set goalMet to true

            Goal.goalMet = true;

            // Also set the alpha of the color to higher opacity

            Material mat = GetComponent<Renderer>().material;

            Color c = mat.color;

            c.a = 1;

            mat.color = c;


        }
        if (Goal.goalMet == true){
            SceneManager.LoadScene("Main-Prototype 1");
        }

    }
}
