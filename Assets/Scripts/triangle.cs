using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1;
    // Update is called once per frame
    void Update()  
    {
        transform.position += new Vector3(-3, 5) * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Debug.Log("The fog is comming.");
        }
    }
}
