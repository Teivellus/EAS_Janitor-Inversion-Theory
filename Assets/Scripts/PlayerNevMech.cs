using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;


public class PlayerNevMech : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent NavMeshAgent;
    SphereCollider detactZone;
    public bool allowAction = false;

    private void Awake()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
    }



    // Update is called once per frame
    private void Update()
    {
       
        findEm();
        
    }

    public void findEm()
    {
        if (allowAction == true)
        {
            NavMeshAgent.destination = movePositionTransform.position;
        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(allowAction);
            allowAction = true;
            detactZone.radius += 2f;

        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            allowAction = false;
            Debug.Log(allowAction);
            detactZone.radius -= 1f;
        }
    }
}
