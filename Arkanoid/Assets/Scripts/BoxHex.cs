using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHex : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            Destroy(gameObject);
            /*Revisar esta funci�n, se clonar� con distintas cantidades de vida y puntos para cada tipo de BoxHex. Se coloca un int con 
            la cantidad de vida de cada tipo, en este collision este int = -1, perdi�ndose una vida por impacto, m�s adelante en un
            if diferente se puede colocar que si la vida int = 0, se destruya el objeto.*/
        }
    }
}
