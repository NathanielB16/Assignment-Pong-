using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Mouse : MonoBehaviour {

    //Declaring three variables that can only be used in this script

    private float speed; //Declaring a float variable

    private Rigidbody2D P2_RB; //Declaring a variable that can only be used here

    private float BoundaryY = 3.125f; //Initialising boundaryY value to float 3.125

    void Start ()
    {

        P2_RB = this.GetComponent<Rigidbody2D>(); //Getting the rigidbody 2d component and storing it into variable

        speed = 5; //Setting the value for speed to 5
		
	}

	void Update ()
    { 
        // Declaring the Player2 position
        float PlayerPosInUnits = (Input.mousePosition.y / Screen.height * 15.6f)-7.8f;

        //Declaring the x, y, z positions
        Vector3 PlayerPosition = new Vector3(5.6f, PlayerPosInUnits, this.transform.position.x);

        //Getting the position and storing it into variable named PlayerPosition
        this.transform.position = PlayerPosition;

        var Position = transform.position; //Position is = to position movement

        if (Position.y > BoundaryY) //Stops when mouse goes to the top of screen
        {
            Position.y = BoundaryY;
        }
        else if (Position.y < -BoundaryY) //Stops when mouse goes to the bottom of screen
        {
            Position.y = -BoundaryY;
        }

        // Updates Posiotion of Variable Position
        transform.position = Position;
		
	}

}
