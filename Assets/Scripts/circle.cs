using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    public float speed = 1f;
    public float xPosition = -2f;
    public float yPosition = -3f;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
        xPosition = xPosition + -0.005f;
        yPosition = yPosition + 0.001f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null) {
            Debug.Log("Auw!");
        }
    }
}
