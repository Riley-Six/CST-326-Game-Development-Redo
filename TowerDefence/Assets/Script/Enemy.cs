using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public Waypoint currentDestination;
  public WaypointManager waypointManager;
  private int currentIndexWaypoint = 0;
  public float speed = 1;
  public float health = 5;
  public GameObject weapon;
  public GameObject hpBar;

    public void Initialize(WaypointManager waypointManager)
  {
    this.waypointManager = waypointManager;
    GetNextWaypoint();
    transform.position = currentDestination.transform.position; // Move to WP0
    GetNextWaypoint();
  }

  void Update()
  {
    Vector3 direction = currentDestination.transform.position - transform.position;
    if (direction.magnitude < .2f)
    {
      GetNextWaypoint();
    }

    transform.Translate(direction.normalized * speed * Time.deltaTime);
  }

  private void GetNextWaypoint()
  {
    currentDestination = waypointManager.GetNeWaypoint(currentIndexWaypoint);
    currentIndexWaypoint++;
  }

    /*
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I was hit by a Ray");
        health -= 1;
        if (health == 0)
        {
            //Object.Destroy(this.gameObject);
        }


    }/*
    private void HitByRaycast(source weapon)
    {
        Debug.Log("Hello: " );
    }
    public class ObjectHit : MonoBehaviour
    {
        void HitByRay()
        {
            Debug.Log("I was hit by a Ray");
        }
    }*/
    public void damaging()
    {

        Debug.Log("I was hit by a Ray" + health);
        health -= 1;
        hpBar.SendMessage("hurt");
        //healthBar.hurt();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        
    }







}
