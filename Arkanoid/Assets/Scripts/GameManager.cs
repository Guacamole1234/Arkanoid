using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;


    public void loseHealth()
    {
        lives--; //Me qued� en el cuarto cap�tulo del tutorial
    }
}
