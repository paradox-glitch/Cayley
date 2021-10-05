using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float _pitch, _roll, _endUp, _endForward;

    public Rigidbody gggg;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //if(
     //   Input.GetKeyDown(KeyCode.W))
     //   {
     //       //tilt forwarn
     //   
        
        // player input chnage angle
 
    }

    private void FixedUpdate()
    {
        // mths and shit


        


        gggg.AddRelativeForce(0, _endUp, _endForward, ForceMode.Acceleration);
    }
}
