using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public GameObject destino;
    private UnityEngine.AI.NavMeshAgent agenteDeNavegacion;
    // Start is called before the first frame update
    void Start()
    {
        agenteDeNavegacion = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agenteDeNavegacion.SetDestination(destino.transform.position);
    }

   
}
