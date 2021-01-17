using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HorseScript : MonoBehaviour
{
    public NavMeshAgent agent;
    [SerializeField] float navSpeed;
    public GameObject finishLine;
    bool increaseExtra = false;
    Animator anim;

    float minSpeed = 15f;
    float maxSpeed = 40f;


    public GameObject firstPlace;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.enabled = false;

        navSpeed = agent.speed = Random.Range(minSpeed, maxSpeed);
        anim = GetComponent<Animator>();
        


     

        Invoke("enableAgent", 15f);
    }

    // Update is called once per frame
    void Update()
    {

        SetDestination();

       
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
  void enableAgent()
    {
        agent.enabled = true;
        anim.SetBool("gameHasStarted", true);
    }

}
