using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 3;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(10, 10, 6) * speed * Time.deltaTime;
    }
}
