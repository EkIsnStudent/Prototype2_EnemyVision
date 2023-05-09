using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{

    private NavMeshAgent _enemyNavMeshAgent;

    public GameObject hunter, player;
    public Transform playerPos;
    public float distanceA;
    private bool _followAlways = false;


    private void Awake()
    {
        _enemyNavMeshAgent = GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InitiateFollow();

        if (_followAlways == true)
        {
            _enemyNavMeshAgent.destination = playerPos.position;
        }
    }

    private void InitiateFollow()
    {
        distanceA = Vector3.Distance(hunter.transform.position, player.transform.position);

        if (distanceA <= 25)
        {

            _enemyNavMeshAgent.destination = playerPos.position;
            _followAlways = true;
        } else
        {
            _enemyNavMeshAgent.destination = _enemyNavMeshAgent.transform.position;
        }
    }
}
