using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeLaCamara : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 posicionRelativa;
    //sino se indica private, es lo mismo

    // Start is called before the first frame update
    void Start()
    {
        posicionRelativa = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + posicionRelativa;
    }
}
