using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //Declaring private variable Ball_RB
    private Rigidbody2D Ball_RB;

    void Start () {

        StartCoroutine(PausePeriodAfterGoal()); //Calling the PausePeriodAfterGoal function

        Ball_RB = this.GetComponent<Rigidbody2D>(); //Getting the rigidbody 2d component and storing it into variable

        //Setting the initial velocity of the ball
        Ball_RB.velocity = new Vector2(6f, 6f);

    }
	
	void Update () {

        if (this.transform.position.x >= 7.8f) //When ball goes past left screen 
        {
            this.transform.position = new Vector3(0f, 0f, 0f); //Place ball at the center
            Ball_RB.velocity = new Vector3(0f, 0f, 0f); //Set velocoty to 0
            ScoreCount.instance.P1_Point();
            StartCoroutine(PausePeriodAfterGoal()); //Calling the PausePeriodAfterGoal function
        }
        if (this.transform.position.x <= -7.8f) //When ball goes past left screen 
        {
            this.transform.position = new Vector3(0f, 0f, 0f); //Place ball at the center
            Ball_RB.velocity = new Vector3(0f, 0f, 0f);//Set velocoty to 0
            ScoreCount.instance.P2_Point();
            StartCoroutine(PausePeriodAfterGoal()); //Calling the PausePeriodAfterGoal function
        }

    }

    void BallLaunchAfterGoal() //Creating a function called BallLaunchAfterGoal
    {

        this.transform.position = new Vector3(0f, 0f, 0f); //Place ball at the center

        int DirX = Random.Range(-1, 2); //Getting a random value for x 
        int DirY = Random.Range(-1, 2); //Getting a random value for x


        if (DirX == 0)
        {
            DirX = 1;
        }

        Ball_RB.velocity = new Vector2(7f * DirX, 7f * DirY);
    }

    IEnumerator PausePeriodAfterGoal() //Built in Function IEnumerator with name PausePeriodAfterGoal
    {
        
        yield return new WaitForSeconds(2f); //Waiting for 2 seconds

        BallLaunchAfterGoal(); //Calling the BallLaunchAfterGoal function

    }

    private void OnCollisionEnter2D(Collision2D Coll) ////Built in Function OnCollisionEnter2D
    {

        //If ball hits the top of the scrren
        if (Coll.gameObject.name == "Top_Collider")
        {

            //Declaring variable XSpeed of value 0
            float XSpeed = 0f;

            if (Ball_RB.velocity.x > 0f)
            {
                XSpeed = 8f; //Setting speed to 8
            }

            if (Ball_RB.velocity.x < 0f)
            {
                XSpeed = -8f; //Setting speed to 8
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
                XSpeed = 8f; //Setting speed to 8
            }

            if (Ball_RB.velocity.x < 0f)
            {
                XSpeed = -8f; //Setting speed to 8
            }

            //Changing the velocity of the ball to what XSpeed is
            Ball_RB.velocity = new Vector3(XSpeed, 8f, 0f);

        }

        if (Coll.gameObject.name == "P1")
        {
            Ball_RB.velocity = new Vector3(13f, 0f, 0f); //Setting the initial speed

            if (transform.position.y - Coll.gameObject.transform.position.y < -0.7) // if ball hits lower part of paddle
            {
                Ball_RB.velocity = new Vector3(8f, -8f, 0f);  //Changing the speed and angle according to where it hits
            }

            if (transform.position.y - Coll.gameObject.transform.position.y > 0.6) // if ball hits higher part of paddle
            {
                Ball_RB.velocity = new Vector3(8f, 8f, 0f);  //Changing the speed and angle according to where it hits
            } 
        }

        if (Coll.gameObject.name == "P2")
        {
            Ball_RB.velocity = new Vector3(-13f, 0f, 0f); //Setting the initial speed

            if (transform.position.y - Coll.gameObject.transform.position.y < -0.7) // if ball hits higher part of paddle
            {
                Ball_RB.velocity = new Vector3(-8f, -8f, 0f); //Changing the speed and angle according to where it hits
            }

            if (transform.position.y - Coll.gameObject.transform.position.y > 0.6)// if ball hits higher part of paddle
            {
                Ball_RB.velocity = new Vector3(-8f, 8f, 0f); //Changing the speed and angle according to where it hits
            }
        }

    }

}
