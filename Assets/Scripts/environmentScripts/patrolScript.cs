using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolScript : MonoBehaviour
{ 
    //<SUMMARY>
    //Enemy is designed to patrol along set points in gamespace
    //enemy will be detroyed if it comes in contact with a bullet

public Transform[] PatrolPoints;
public float Speed;


Transform CurrentPatrolPoint;
int CurrentPatrolIndex;



// Use this for initialization
void Start()
{
    CurrentPatrolIndex = 0;
    CurrentPatrolPoint = PatrolPoints[CurrentPatrolIndex];
}

// Update is called once per frame
void Update()
{//Dictates enemy movement based on patrol points.
    transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    //check to see if enemy has reached patrol point
    if (Vector3.Distance(transform.position, CurrentPatrolPoint.position) < 10f)
    //once patrol point is reached is loads next point from array
    {
        if (CurrentPatrolIndex + 1 < PatrolPoints.Length)
        {
            CurrentPatrolIndex++;
        }
        else
        {
            CurrentPatrolIndex = 0;
        }

        CurrentPatrolPoint = PatrolPoints[CurrentPatrolIndex];
    }


    Vector3 PatrolPointDir = CurrentPatrolPoint.position - transform.position;
    float angle = Mathf.Atan2(PatrolPointDir.y, PatrolPointDir.x) * Mathf.Rad2Deg - 90;
    Quaternion NewAngle = Quaternion.AngleAxis(angle, Vector3.forward);
    transform.rotation = Quaternion.RotateTowards(transform.rotation, NewAngle, 180f);

}

 

}

