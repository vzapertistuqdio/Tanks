using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TapController : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hitInfo;

    private Vector3 clickPosition;

    private NavMeshAgent navAgent;

    [SerializeField] private LineRenderer lineRenderer;
    private void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        lineRenderer.enabled = false;
    }

    
    private void Update()
    {
        lineRenderer.SetPosition(0, transform.position);
       
        if (Input.GetMouseButton(0))
        {
           ray=Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hitInfo))
            {
                lineRenderer.enabled = true;
                
                lineRenderer.SetPosition(1,hitInfo.point);
                navAgent.SetDestination(hitInfo.point);
            }
        }
    }
}
