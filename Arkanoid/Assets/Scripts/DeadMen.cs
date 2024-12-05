using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadMen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PowerInverted"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Jugador"))
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
