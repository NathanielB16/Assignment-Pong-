using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Mouse : MonoBehaviour {

    //Declaring three variables that can only be used in this script

    private float speed;

    private Rigidbody2D P2_RB;

    private float BoundaryY = 3.7f;

    void Start ()
    {

        P2_RB = this.GetComponent<Rigidbody2D>();

        speed = 5;
		
	}

	void Update ()
    { 
        // Declaring the Player2 position
        float PlayerPosInUnits = (Input.mousePosition.y / Screen.height * 13f)-6.5f;

        //Declaring the x, y, z positions
        Vector3 PlayerPosition = new Vector3(8.56f, PlayerPosInUnits, this.transform.position.x);

        //Getting the position and storing it into variable named PlayerPosition
        this.transform.position = PlayerPosition;

        var Position = transform.position;

        if (Position.y > BoundaryY)
        {
            Position.y = BoundaryY;
        }
        else if (Position.y < -BoundaryY)
        {
            Position.y = -BoundaryY;
        }

        // Updates Posiotion of Variable Position
        transform.position = Position;
		
	}

}
