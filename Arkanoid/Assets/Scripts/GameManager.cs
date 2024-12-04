using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;


    public void loseHealth()
    {
        lives--; //Me quedé en el cuarto capítulo del tutorial
    }
}
