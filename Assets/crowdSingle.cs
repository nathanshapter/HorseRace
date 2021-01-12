using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowdSingle : MonoBehaviour
{
    Animator anim;
    void Start()
    {
       
        float jumpSpeed = Random.Range(1f, 3f);
        anim = GetComponent<Animator>();
        
      
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("gameStarted", true);
        
    }
    public void BlueWon()
    {
        anim.SetBool("blueWon", true);

        Debug.Log("any horse has won");
    }
    public void GreenWon()
    {
        Debug.Log("any horse has won");
    }
    public void YellowWon()
    {
        Debug.Log("any horse has won");
    }
    public void PinkWon()
    {
        Debug.Log("any horse has won");
    }
}
