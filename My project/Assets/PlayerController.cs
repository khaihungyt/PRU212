using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public int speed = 5;
    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Horizontal");
        float Y = 0;
        Vector3 move = new Vector3(X, Y, 0) * speed * Time.deltaTime;
        transform.Translate(move);
    }
}
