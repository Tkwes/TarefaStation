using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agentmanager : MonoBehaviour
{
    // cria um list de objetos 
    GameObject[] agentes;

    // Start is called before the first frame update
    void Start()
    {
        // Busca um gamrobject que contenha a tag Ai
        agentes = GameObject.FindGameObjectsWithTag("Ai"); 
    }

    // Update is called once per frame
    void Update()
    {
        //condicional de precionar botao
        if (Input.GetMouseButtonDown(0))
        {
            //pega a propriedade hit do raycast
            RaycastHit hit;

            //detecta se o desparo esta em objeto 
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) 
            {
                foreach (GameObject a in agentes)
                    // seta uma nova direcao para os objetos apartir do hit, ponto de contato 
                    a.GetComponent<AIcontrol>().agent.SetDestination(hit.point);
            }


        }



    }
}
