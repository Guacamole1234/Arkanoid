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
            /*Revisar esta función, se clonará con distintas cantidades de vida y puntos para cada tipo de BoxHex. Se coloca un int con 
            la cantidad de vida de cada tipo, en este collision este int = -1, perdiéndose una vida por impacto, más adelante en un
            if diferente se puede colocar que si la vida int = 0, se destruya el objeto.*/
        }
    }
}
