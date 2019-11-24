using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour {

    public GameObject Plataforma;    
    public Transform[] MovePoint;
    public float speed;
    public float RotationSpeed;

    private int pointSelection;
    private Transform currentPoint;


    void Start()
    {
        currentPoint = MovePoint[pointSelection];
    }

	// Update is called once per frame
	void Update () {

        Plataforma.transform.position = Vector3.MoveTowards(Plataforma.transform.position, currentPoint.position, Time.deltaTime * speed);
        
        if(Plataforma.transform.position == currentPoint.position)
        {
            pointSelection++;

            if (pointSelection == MovePoint.Length)
            {
                pointSelection = 0;
                Plataforma.transform.Rotate(0, RotationSpeed*Time.deltaTime, 0);
            }
            currentPoint = MovePoint[pointSelection];
        }
	}
}
