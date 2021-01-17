using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowdSingle : MonoBehaviour
{
    Animator anim;
    
    
    

    void Start()
    {
             
        anim = GetComponent<Animator>();
        anim.SetBool("gameStarted", true);
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Random.Range(1,10) <= 1)
        {
            anim.SetBool("playNext", true);
            Invoke("playNextFalse", 2);
        }


        
    }
    void playNextFalse()
    {
        anim.SetBool("playNext", false);
    }

}
