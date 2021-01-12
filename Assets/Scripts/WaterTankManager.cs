using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTankManager : MonoBehaviour
{
    public GameObject[] tanks;
    //[SerializeField] Animator[] anim;
    
    void Start()
    {

        //anim = GetComponentsInChildren<Animator>();
        tanks = GameObject.FindGameObjectsWithTag("crowd");
        float jumpSpeed = Random.Range(1, 3);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
