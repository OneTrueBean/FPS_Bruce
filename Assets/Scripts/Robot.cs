using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
   
    [SerializeField] Transform player;
    UnityEngine.AI.NavMeshAgent agent;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
