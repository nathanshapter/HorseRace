using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FinishLine : MonoBehaviour
{
    HorseScript hs;
    public Transform firstTTarget;
    
    public List<GameObject> horseList = new List<GameObject>();

        
    public ParticleSystem winner;
    public ParticleSystem[] numerousConfetti; // drag into inspector
    bool firstPlace = false;

    public AudioSource startShot;
       void Start()
    {
   
        winner.Stop();
        foreach (ParticleSystem i in numerousConfetti)
        {
            i.Stop();
        }
        startShot = GetComponent<AudioSource>();
        Invoke("startGame", 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnTriggerEnter(Collider other)
    {
        horseList.Add(other.gameObject);

        horseList[0].GetComponent<GameObject>();

        if(horseList[0] != null)
        {
            Debug.Log(horseList[0] + " has won!");
            winner.Play();
            

            if (!firstPlace)
            {
                foreach (ParticleSystem i in numerousConfetti)
                {
                    i.Play();
                }
                firstPlace = true;
            }
          
            

            
                
                
            
        }
        if(horseList[1] != null)
        {
            Debug.Log(horseList[1] + " has come in Second Place!");
           
           
        }
        if(horseList[2] != null)
        {
            Debug.Log(horseList[2] + " has come in Third Place");
            
            
        }
        if(horseList[3] != null)
        {
            Debug.Log(horseList[3] + " has come in Fourth Place!");
            
        }

            
    }
   
  void startGame()
    {
        startShot.Play();
        hs.agent.enabled = true;
    }
}
