using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HorseScript : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] float navSpeed;
    public GameObject finishLine;
    bool increaseExtra = false;

    float minSpeed = 15f;
    float maxSpeed = 40f;
    bool hasWon = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        navSpeed = agent.speed = Random.Range(minSpeed, maxSpeed);


        //UnityEditor.AI.NavMeshBuilder.BuildNavMesh();
       
    }

    // Update is called once per frame
    void Update()
    {
        SetDestination();

        if (hasWon)
        {
            HasWon();
        }
    }

    private void SetDestination()
    {
        agent.SetDestination(finishLine.transform.position);

        if (Random.Range(0, 100) < 1)
        {

            IncreaseSpeed();
        }
        if (agent.speed < 30)
        {
            if (Random.Range(0, 100) < 5)
            {
                IncreaseSlowSpeed();
            }
        }
    }

    void IncreaseSpeed()
    {
        navSpeed = agent.speed += Random.Range(1, 3);
    }
    void IncreaseSlowSpeed()
    {
        if (!increaseExtra)
        {
            navSpeed = agent.speed += Random.Range(2, 4);
            increaseExtra = true;
        }
        
    }
    void HasWon()
    {

    }

}
