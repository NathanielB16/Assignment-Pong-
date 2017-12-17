using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Controller : MonoBehaviour {

    public GameObject Obstacle;

    public float Speed;

    public Transform Starting_Pt;

    public Transform[] points;

    public int Pt_Choice;

	void Start () {

        Starting_Pt = points[Pt_Choice];
		
	}
	
	void Update () {

        Obstacle.transform.position = Vector3.MoveTowards(Obstacle.transform.position, Starting_Pt.position, Time.deltaTime * Speed);

        if (Obstacle.transform.position == Starting_Pt.position)
        {

            Pt_Choice++;

            if (Pt_Choice == points.Length)
            {

                Pt_Choice = 0;

            }

            Starting_Pt = points[Pt_Choice]; 
        }
	}
}
