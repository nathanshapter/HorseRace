using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FinishLine : MonoBehaviour
{
    public Transform firstTTarget;
    
    public List<GameObject> horseList = new List<GameObject>();

    HorseScript hs;
    crowdSingle cs;
    public GameObject firstPlace;

    /*
    bool gameStarted = false;
    bool blueWon = false;
    bool blueLost = false;
    bool greenWon = false;
    bool greemLost = false;
    bool yellowWon = false;
    bool yellowLost = false;
    bool pinkWon = false;
    bool pinkLost = false;
    */




    void Start()
    {
        hs = GetComponent<HorseScript>();
        cs = GetComponent<crowdSingle>();
      
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
   
  
}
