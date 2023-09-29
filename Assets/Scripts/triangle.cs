using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle : MonoBehaviour
{
    public float speed = 1f;
    public float xPosition = 2f;
    public float yPosition = -3f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(xPosition, yPosition, 0f);
    }
    
    // Update is called once per frame
    void Update()  
    {
        transform.position += new Vector3(xPosition, yPosition, 0f) * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Debug.Log("The fog is comming.");
        }
    }
}
