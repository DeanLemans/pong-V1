using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bPaddle : MonoBehaviour
{
    public float speed = 7f;
    public string leftOrRight;
    public float maxValue = 7f;

    public float botSpeed = 4f;
    public float botYPosition = 0f;
    public float botXPosition;
    public GameObject square;
    public GameObject paddleLeft;
    public GameObject paddleRight;


    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {
            Debug.Log("fuck you");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            Debug.Log("fuck of dipshit");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Botpaddle()
    {
        transform.position = new Vector3(botXPosition, botYPosition, 0f);
        //transform.position = new Vector3(transform.position.x, ball.transform.position.y, 0f);
        //bot up
        if (square.transform.position.y > square.transform.position.y && transform.position.y < maxValue)
        {
            botYPosition += botSpeed * Time.deltaTime;
        }
        //bot down
        else if (square.transform.position.y < square.transform.position.y && transform.position.y > -maxValue)
        {
            botYPosition += -botSpeed * Time.deltaTime;
        }
    }
}
