using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float xPosition = 5f;
    public float yPosition = 3f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the object. (it wont fucking move)
        transform.position += new Vector3(xPosition, yPosition, 0f) * speed * Time.deltaTime; //google found method
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(""))
        {
            Debug.Log("Fuck!");
        }
    }
}
