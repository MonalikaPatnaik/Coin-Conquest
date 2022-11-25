using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private WayPointPath _WayPointPath;

    [SerializeField]
    private float _speed; 

    private int _targetWaypointIndex;

    private Transform _previousWaypoint;
    private Transform _targetWaypoint;

    private float _timeToWaypoint;
    private float _elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        TargetNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;

        float elapsedPercentage = _elapsedTime / _timeToWaypoint;
    
        
        if(elapsedPercentage >= 1){
            TargetNextWaypoint();
        }
    }



    private void TargetNextWaypoint(){
        _previousWaypoint = _WayPointPath.GetWayPoint(_targetWaypointIndex);
        _targetWaypointIndex = _WayPointPath.GetNextWaypointIndex(_targetWaypointIndex);
        _targetWaypoint = _WayPointPath.GetWayPoint(_targetWaypointIndex);

        _elapsedTime = 0;

        float distanceToWaypoint = Vector3.Distance(_previousWaypoint.position, _targetWaypoint.position);
        _timeToWaypoint = distanceToWaypoint / _speed;
    }
}
