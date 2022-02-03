using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    public static float bottomY = -20f;
    // Start is called before the first frame update
    
    void Start()
    {
        // Dropping apples every second
        Invoke( "DropApple", 2f)
    }

    void DropApple() {
        GameObject apple = Instantiate<GameObject>;
        apple.transform.position = transform.position;
        Invoke( "DropApple", secondsBetweenAppleDrops );
    }
    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position;

        pos.x += speed * Time.deltaTime;

        transform.position = pos;

        // Changing Direction

        if ( post. < -leftAndRightEdge ) {
            speed = Mathf.Abs(speed); // Move right
        }
        else if ( pos.x > leftAndRightEdge ) {
            speed = -Mathf.Abs(speed); // Move left
        }
        else if ( Random.value < chanceToChangeDirections ) {
            speed *= -1; // Change direction
        }
    }

    void FixedUpdate() {
        //Changing Direction Randomly is now t
        if ( Random.value < chanceToChangeDirections) {
            speed *= -1; // Change direction
        }
    }
}
