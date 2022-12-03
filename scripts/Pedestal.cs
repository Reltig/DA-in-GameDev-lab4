using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour
{
    public int State{get; set;}
    void Start()
    {
        State = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "OneCube")
            State = 1;
    }

    void OnCollisionExit(Collision collision){
        if(collision.collider.tag == "OneCube")
            State = 0;
    }
}
