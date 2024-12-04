using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    float inputValue;
    public float moveSpeed = 10f;
    private Vector3 direction;
    void Start()
    {   
        
    }


    void Update()
    {
        inputValue = Input.GetAxis("Horizontal");
        if (inputValue == 1)
        {
            direction = Vector3.right;
        }
        else if (inputValue == -1)
        {
            direction = Vector3.left;
        }
        else 
        {
            direction = Vector3.zero;
        }
        rb.AddForce(direction * moveSpeed * Time.deltaTime * 100);
    }
}
