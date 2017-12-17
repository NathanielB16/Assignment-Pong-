using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Controller : MonoBehaviour {

    public GameObject Obstacle;

    public float Speed;

    public Transform Starting_Pt;

    public Transform[] points; //Declaring an array called points

    public int Pt_Choice;

	void Start () {

        Starting_Pt = points[Pt_Choice]; //Putting Pt_Choice into the points array
	}
	
	void Update () {

        Obstacle.transform.position = Vector3.MoveTowards(Obstacle.transform.position, Starting_Pt.position, Time.deltaTime * Speed);

        if (Obstacle.transform.position == Starting_Pt.position)
        {

            Pt_Choice++; //Incrementing Pt_Choice by 1

            if (Pt_Choice == points.Length)
            {

                Pt_Choice = 0; //Setting Pt_Choice to 0

            }

            Starting_Pt = points[Pt_Choice]; //Putting Pt_Choice into the points array
        }
	}
}
