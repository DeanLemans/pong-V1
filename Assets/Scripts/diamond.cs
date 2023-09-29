using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -3f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
        xPosition += xSpeed * Time.deltaTime; //optimised
        yPosition += yPosition + ySpeed * Time.deltaTime; //not optimised
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Debug.Log("Shine bright like a diamond!");
        }
    }
}
