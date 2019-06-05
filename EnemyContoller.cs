using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyContoller : MonoBehaviour
{
	public Transform Player;
	public NavMeshAgent Agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
    	Agent.SetDestination(Player.transform.position);
    }
}

