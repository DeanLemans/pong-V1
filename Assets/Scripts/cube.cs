using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-4,-3,0);
    }

    // Update is called once per frame
    public float speed = 1;
    void Update()
    {
        // Moves the object. (it wont fucking move)
        transform.position += new Vector3(-3, 3) * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Debug.Log("Fuck!");
        }
    }
}
