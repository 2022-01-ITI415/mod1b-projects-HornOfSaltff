using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Header("Set Dynamically")] 
    //public Text scoreGT;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI HighScore;
    
    public float speed = 0;

    private Rigidbody rb;

    private float movementX;
    private float movementY;

    //
    private int scoreCount;
    private int playerHS;
    //

    public AudioSource pudding;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

        //GameObject scoreGO = GameObject.Find("ScoreCounter");
        //scoreGT = scoreGO.GetComponent<Text>();
        //scoreGT.text = "0";

        scoreCount = 0;
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }


    void OnTriggerEnter(Collider other) 
	{
		// ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("Carrot"))
		{
			other.gameObject.SetActive (false);
            //int score = int.Parse(scoreGT.text);
            //score += 100;
            //scoreGT.text = score.ToString();
            scoreCount = scoreCount + 100;

			// Run the 'SetCountText()' function (see below)
			SetCountText ();

            //if (score > HighScoreP.score){
            //    HighScoreP.score = score;
            //}
            if (scoreCount > playerHS){
                playerHS = scoreCount;
                SetCountText ();
            }

		}
        if (other.gameObject.CompareTag ("Pudding"))
		{
			other.gameObject.SetActive (false);
            //int score = int.Parse(scoreGT.text);
            //score += 100;
            //scoreGT.text = score.ToString();

            //if (score > HighScoreP.score){
            //    HighScoreP.score = score;
            //}
            scoreCount = scoreCount + 500;
            pudding.Play();
			// Run the 'SetCountText()' function (see below)
			SetCountText ();

            if (scoreCount > playerHS){
                playerHS = scoreCount;
                SetCountText ();
            }
		}

	}
    void SetCountText()
	{
		countText.text = "Score: " + scoreCount.ToString();
        HighScore.text = "High Score: " + playerHS.ToString();

		
	}
}