using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointPath : MonoBehaviour
{
    public Transform GetWayPoint(int WayPointIndex) {
        return transform.GetChild(WayPointIndex);
    }

    public int GetNextWaypointIndex(int currentWaypointIndex){
        int nextWaypointIndex = currentWaypointIndex + 1;

        if(nextWaypointIndex == transform.childCount){
            nextWaypointIndex = 0;
        }

        return nextWaypointIndex;
    }
}
