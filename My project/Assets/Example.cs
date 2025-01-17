using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
    public float playerX, playerY;
    int count = 0;
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        playerX = transform.position.x;
        playerY = transform.position.y;
        Debug.Log("x=" + playerX + ", y=" + playerY);
        if (playerX > 0 && playerY > 0)
        {
            Debug.Log("Live");
            if (count < 10)
            {
                GameObject obj = new GameObject();
                count++;
            }
        }
        else
        {
            Debug.Log("Die");
        }
    }
}
