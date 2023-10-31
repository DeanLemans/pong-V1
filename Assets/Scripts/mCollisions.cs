using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class mCollisions : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -3f;
    public float xSpeed = 5f;
    public float ySpeed = 5f;
    public TMP_Text scoreBoard;
    public int leftScore = 0;
    public int rightScore = 0;
    public int topScore = 5;

    void resetBall()
    {
        xPosition = 0f;
        yPosition = Random.Range(-2f, -2f);
        xSpeed = xSpeed * -1f;
        ySpeed = ySpeed * -1f;
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
        if (leftScore >= 5)
        {
            scoreBoard.text = "player one has won";
        }
        else if (rightScore >= 5)
        {
            scoreBoard.text = "player two has won";
        }
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
            scoreBoard.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.2f;
        }
    }


}