using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class mPaddle : MonoBehaviour
{
    public float speed = 5;
    public string leftOrRight;
    public float maxValue = 4f;

    
    void Start()
    {
        
    }
    


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

    // Update is called once per frame
    void Update()
    {
        var speed = Random.Range(3, 9);
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}