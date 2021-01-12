using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FinishLine : MonoBehaviour
{
    Vector3 firstPosition;
    Vector3 secondPosition;
    Vector3 thirdPosition;

    public Transform firstTTarget;
    
    public List<GameObject> horseList = new List<GameObject>();

    HorseScript hs;



    public GameObject firstPlace;

    void Start()
    {
        hs = GetComponent<HorseScript>();
         firstPosition = new Vector3(2.84f, 6.3f, 125.31f);
        secondPosition = new Vector3(8.1f, 6.07f, 125.31f);
        thirdPosition = new Vector3(-2.39f, 6.28f, 125.31f);
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
            horseList[0].transform.position = (firstPosition);
           
        }
        if(horseList[1] != null)
        {
            Debug.Log(horseList[1] + " has come in Second Place!");
            horseList[1].transform.position = (firstPosition);
           
        }
        if(horseList[2] != null)
        {
            Debug.Log(horseList[2] + " has come in Third Place");
            horseList[2].transform.position = (thirdPosition);
            
        }
        if(horseList[3] != null)
        {
            Debug.Log(horseList[3] + " has come in Fourth Place!");
            
        }

            
    }
   
    void FirstPlace()
    {

    }
    void SecondPlace()
    {
       
    }
    void ThirdPlace()
    {

    }
    void FourthPlace()
    {

    }
}
