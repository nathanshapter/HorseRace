using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowdSingle : MonoBehaviour
{
    Animator anim;
    void Start()
    {
       // anim = GetComponent<Animator>();
        float jumpSpeed = Random.Range(1f, 3f);
       // anim.SetFloat("jumpSpeed", jumpSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
