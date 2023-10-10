using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using TMPro;

public class collisions : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -3f;
    public float xSpeed = 7f;
    public float ySpeed = 7f;
    public TMP_Text scoreBoard;
    public int leftScore = 0;
    public int rightScore = 0;

    void resetBall()
    {
        xPosition = 0f;
        yPosition = 0f;
        xSpeed = xSpeed * -1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        xPosition += xSpeed * Time.deltaTime; //optimized
        yPosition += ySpeed * Time.deltaTime; 
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("now you bounce");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("fucking dipshit, thats my feet!");
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalL"))
        {
            resetBall();
            rightScore++;
            scoreBoard.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("verticalR"))
        {
            resetBall();
            leftScore++;
            scoreBoard.text = leftScore + " _ " + rightScore;
        }
        else if (collision.gameObject.CompareTag("Player")) 
        {
        xSpeed = xSpeed * -1.1f; 
        }
    }

  
    }
