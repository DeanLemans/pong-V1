using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed = 5f;
    public string leftOrRight;


    void paddleControl(KeyCode up,KeyCode down) 
    {
        if (Input.GetKey(up))
        {
            Debug.Log("fuck you");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down))
        {
            Debug.Log("fuck of dipshit");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        } 
        else if(leftOrRight == "right") 
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}