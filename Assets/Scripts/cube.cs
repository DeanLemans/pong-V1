using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1f;
    public float xPosition = 5f;
    public float yPosition = 3f;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the object. (it wont fucking move)
        transform.position = new Vector3(xPosition, yPosition, 0f);
        xPosition += 0.001f;
        yPosition += 0.005f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Debug.Log("Fuck!");
        }
    }
}
