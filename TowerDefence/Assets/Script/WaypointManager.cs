using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
  public Waypoint[] waypoint;

  void Awake()
  {

    waypoint = GetComponentsInChildren<Waypoint>();
    
  }

  public Waypoint GetNeWaypoint(int currentIndex)
  {
    return waypoint[currentIndex++];
  }
}
