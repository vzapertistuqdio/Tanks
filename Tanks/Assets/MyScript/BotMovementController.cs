using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotMovementController : MonoBehaviour
{
    private NavMeshAgent navAgent;

   [SerializeField] private Transform point1;
    [SerializeField] private Transform point2;
    private Transform currentPoint;
    private void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        currentPoint = point1;
    }

    
    private void Update()
    {
        
        navAgent.SetDestination(currentPoint.position);
    }
    private void Swap()
    {
        if(currentPoint==point1)
        {
            currentPoint =point2;
        }
        else if(currentPoint==point2)
        {
            currentPoint = point1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="point")
        {
            Swap();
        }
    }
}
