using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody2D Ball_RB;

    void Start () {

        Ball_RB = this.GetComponent<Rigidbody2D>();

        Ball_RB.velocity = new Vector2(6f, 6f);

    }
	
	void Update () {

        if (this.transform.position.x >= 7.8f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        if (this.transform.position.x <= -7.8f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }

    }
}
