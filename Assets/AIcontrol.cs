using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIcontrol : MonoBehaviour
{
    public NavMeshAgent agent;//busca um objeto selecionado pelo usuario

    void Start()

    {
        // busca no objeto o componente navmesh
        agent = this.GetComponent<NavMeshAgent>(); 
    }

    
}
