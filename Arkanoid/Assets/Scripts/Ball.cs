using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb_ball;
    public float speed = 300f;
    Vector3 velocity;
    void Start()
    {
        velocity.x = Random.Range(-1f, 1f);
        velocity.y = 1f;
        rb_ball.AddForce(velocity*speed);
    }


    void Update()
    {
        
    }
}
