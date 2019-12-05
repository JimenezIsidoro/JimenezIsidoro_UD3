using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
  
        // 1.
        // 1. El componente transform sirve la situar el objeto en el espacio, orientarlo con respecto a nuestro interes y cambiar su tamaño.
        // 2. GetComponent: Devuelve el componente de tipo Tipo si el objeto del juego tiene uno adjunto, nulo si no lo tiene.
        // 2. ToString: Devuelve el nombre del GameObject.

        // 2.
        // 1. Horizontal; Left/a Right/d Vertical; Up/w Down/s.
        // 2. La fuerza es aplicada continuamente a lo largo de la dirección del vector force.
        // El ForceMode mode le permite al tipo de fuerza cambiar de una Aceleración, Impulso o Cambio de Velocidad.
        // La fuerza se puede aplicar a un Rigidbody activo. Si un GameObject está inactivo, AddForce no tiene efecto.

        // 3.
        // 1. La camara pierde por completo la estabilidad y comienza a rotar en todas las direcciones centradas a la pelota,  mientras que, con el script centra la camara al jugador pero mantine su orientacion y solo cambia su posicion.

    
}
