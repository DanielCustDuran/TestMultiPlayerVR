using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BugAI : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    public Transform transformDestination;
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    void Update()
    {
        _navMeshAgent.SetDestination(transform.position);
    }
}
