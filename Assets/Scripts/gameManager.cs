using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    int leftPlayerPoints = 0;
    int rightPlayerPoints = 0;
    // Start is called before the first frame update
    void Start()
    {
        square = GameObject.FindGameObjectWithTag("Player");
    }
    public static void Score(string wallID)
    {
        if (wallID == "verticalWall")
        {
            PlayerScore1++;
        }
        else
        {
            PlayerScore2++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
