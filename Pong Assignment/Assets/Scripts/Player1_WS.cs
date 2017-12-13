using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_WS : MonoBehaviour {

    private Rigidbody2D P1_RB;

	void Start () {

        P1_RB = this.GetComponent<Rigidbody2D>();
		
	}
	
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            P1_RB.velocity = new Vector2(0f, 5f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            P1_RB.velocity = new Vector2(0f, -5f);
        }
        else
        {
            P1_RB.velocity = new Vector2(0f, 0f);
        }
		

    }
}
