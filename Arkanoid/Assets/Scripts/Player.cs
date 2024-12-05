using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    float inputValue;
    public float moveSpeed = 10f;
    private Vector3 direction;
    bool inverted = false;
    public float timeinverted = 10f;

    void Start()
    {   
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.CompareTag("PowerInverted"))
        {
            inverted = true;
        }*/
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            inverted = true;
        }
        inputValue = Input.GetAxis("Horizontal");
        if (inverted == true)
        {
            if (inputValue == 1)
            {
                direction = Vector3.left;
            }
            else if (inputValue == -1)
            {
                direction = Vector3.right;
            }
            else
            {
                direction = Vector3.zero;
            }
            timeinverted = timeinverted - Time.deltaTime;
        }
        else
        {
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
        }
        if (timeinverted <= 0)
        {
            inverted = false;
            timeinverted = 10f;
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
        }
        rb.AddForce(direction * moveSpeed * Time.deltaTime * 100);
    }
}
