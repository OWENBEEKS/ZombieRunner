using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{  
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;

    UnityEngine.AI.NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;

    void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        
        if(distanceToTarget <= chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
