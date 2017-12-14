using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //Declaring private variable Ball_RB
    private Rigidbody2D Ball_RB;

    void Start () {

        Ball_RB = this.GetComponent<Rigidbody2D>();

        //Setting the initial velocity of the ball
        Ball_RB.velocity = new Vector2(6f, 6f);

        StartCoroutine(Pause());

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

        StartCoroutine(Pause());

    }

    private void OnCollisionEnter2D(Collision2D Coll)
    {

        //If ball hits the top of the scrren
        if (Coll.gameObject.name == "Top_Collider")
        {

            //Declaring variable XSpeed of value 0
            float XSpeed = 0f;

            if (Ball_RB.velocity.x > 0f)
            {
                XSpeed = 8f;
            }

            if (Ball_RB.velocity.x < 0f)
            {
                XSpeed = -8f;
            }

            //Changing the velocity of the ball to what XSpeed is
            Ball_RB.velocity = new Vector3(XSpeed, -8f, 0f);

        }

        //If ball hits the bottom of the scrren
        if (Coll.gameObject.name == "Bottom_Collider")
        {

            //Declaring variable XSpeed of value 0
            float XSpeed = 0f;

            if (Ball_RB.velocity.x > 0f)
            {
                XSpeed = 8f;
            }

            if (Ball_RB.velocity.x < 0f)
            {
                XSpeed = -8f;
            }

            //Changing the velocity of the ball to what XSpeed is
            Ball_RB.velocity = new Vector3(XSpeed, 8f, 0f);

        }

        //If ball hits Player 1 (left Player)
        if (Coll.gameObject.name == "P1")
        {

            //Direct Collision
            Ball_RB.velocity = new Vector3(13f, 0f, 0f);

            //Lowe Paddle Collision
            if (transform.position.y - Coll.gameObject.transform.position.y < -0.7)
            {
                Ball_RB.velocity = new Vector3(8f, -8f, 0f);
            }

            //Upper Paddle Collision
            if (transform.position.y - Coll.gameObject.transform.position.y > 0.5)
            {
                Ball_RB.velocity = new Vector3(8f, 8f, 0f);
            }

        }

        //If ball hits Player 1 (right Player)
        if (Coll.gameObject.name == "P2")
        {

            //Direct Collision
            Ball_RB.velocity = new Vector3(-13f, 0f, 0f);

            //Lower Paddle Collision
            if (transform.position.y - Coll.gameObject.transform.position.y < -0.7)
            {
                Ball_RB.velocity = new Vector3(-8f, -8f, 0f);
            }

            //Upper Paddle Collision
            if (transform.position.y - Coll.gameObject.transform.position.y > 0.5)
            {
                Ball_RB.velocity = new Vector3(-8f, 8f, 0f);
            }

        }

    }

    IEnumerator Pause()
    {

        int DirX = Random.Range(-1, 2);
        int DirY = Random.Range(-1, 2);


        if (DirX == 0)
        {
            DirX = 1;
        }

        Ball_RB.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        Ball_RB.velocity = new Vector2(7f * DirX, 7f * DirY);

    }

}
