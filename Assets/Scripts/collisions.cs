using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -3f;
    public float xSpeed = 7.5f;
    public float ySpeed = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        
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
        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            Debug.Log("fucking dipshit, thats my head!");
            xSpeed = xSpeed * -1f;
        }
    }

  
    }
