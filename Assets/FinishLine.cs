using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("potato");
       if(tag == "blueHorse")
        {
            Debug.Log("Blue Wins!");
                           
        }
        if (tag == "greenHorse")
        {
            Debug.Log("Green Wins!");

        }
        if (tag == "yellowHorse")
        {
            Debug.Log("Yellow Wins!");

        }
        if (tag == "pinkHorse")
        {
            Debug.Log("Blue Wins!");

        }

    }
}
