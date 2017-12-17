using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_WS : MonoBehaviour {


    //Declaring a variable that can only be accessed on this script
    private Rigidbody2D P1_RB;

	void Start () {

        //Getting the rigidbody 2d component and storing it into variable
        P1_RB = this.GetComponent<Rigidbody2D>();
		
	}
	
	void Update () {

        //When user presses W
        if (Input.GetKey(KeyCode.W))
        {
            P1_RB.velocity = new Vector2(0f, 5f); //Move up by 5
        }
        else if (Input.GetKey(KeyCode.S)) //When user presses S
        {
            P1_RB.velocity = new Vector2(0f, -5f); //Move down by 5
        }
        else //If user presses nothing 
        {
            P1_RB.velocity = new Vector2(0f, 0f); //Don't move
        }
		

    }
}
