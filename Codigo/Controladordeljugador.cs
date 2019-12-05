using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// permite trabajar con Text

public class Controladordeljugador : MonoBehaviour
{
    public Text marcador;
    public float velocidad;
    Rigidbody rb;
    public int contador;
    public Text findejuego;
    // Define variables para almacenar items recogidos
    int numItems_1;
    int numItems_2;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        findejuego.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    //Collider es el objeto con el que ha colisionado
    {
        if (other.tag == "Suma1")

        {
            Destroy(other.gameObject);
            contador = contador + 1;
            numItems_1 = numItems_1 + 1;
        }

        else if (other.tag == "Suma2")

        {
            Destroy(other.gameObject);
            contador = contador + 2;
            numItems_2 = numItems_2 + 1;
        }

        else if (other.tag == "Resta1")


        {
            Destroy(other.gameObject);
            contador = contador - 1;
        }

        ActualizarMarcador();

        if (numItems_1 >=5 && numItems_2 >=1)

        {
            findejuego.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }
    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f,
            movimientoVertical);
            rb.AddForce(movimiento*velocidad);

       
    }
     


    void ActualizarMarcador()
    {
        marcador.text = "Puntos: " + contador;
    }
    //Arreglar

    }
