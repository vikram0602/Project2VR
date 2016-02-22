using UnityEngine;
using System.Collections;

public class bl_RandomBot : MonoBehaviour {


    void FixedUpdate()
    {
        if (!Agent.hasPath)
        {
            RandomBot();
        }
    }

    void RandomBot()
    {
        Vector3 randomDirection = Random.insideUnitSphere * 50;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, 50, 1);
        Vector3 finalPosition = hit.position;
        Agent.SetDestination(finalPosition);
    }

    private NavMeshAgent m_Agent;
    private NavMeshAgent Agent
    {
        get
        {
            if (m_Agent == null)
            {
                m_Agent = GetComponent<NavMeshAgent>();
            }
            return m_Agent;
        }
    }
}