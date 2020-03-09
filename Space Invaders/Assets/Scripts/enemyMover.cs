using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMover : MonoBehaviour
{
    public Transform enemyBox;
    public float speed, leftWall, rightWall, startSpotY, howMuchDown, bottom;
    private int direction = 1;
    //private int down = startS[;
    private int movement = 0;
    private float temp;
    //private float bottomBar = bottom * howMuchDown;
    // Start is called before the first frame update
    void Start()
    {
        enemyBox = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == 1)
        {
            //enemyBox.position = transform.right + speed*direction;
            movement += direction;
            if(enemyBox.position.x > rightWall)
            {
                direction = -1;
                startSpotY -= 1;
            }
        } else
        {
            //enemyBox.position = transform.right + speed*direction;
            movement += direction;
            if (enemyBox.position.x < leftWall)
            {
                direction = 1;
                startSpotY -= 1;
            }

        }

        temp = howMuchDown * startSpotY;

        if (startSpotY >= -29)
        {
            //Vector3 moveIt = new Vector3(movement * (speed / 200), 0.0f, 0.0f);
            //enemyBox.position = moveIt /*Vector3.right * movement * (speed / 50)*/;
            Vector3 moveIt = new Vector3(movement * (speed / 200), temp, 0.0f);
            enemyBox.position = moveIt /*Vector3.right * movement * (speed / 50)*/;
        } else
        {
            
            //Vector3 moveIt = new Vector3(movement * (speed / 200), 0.0f, 0.0f);
            //enemyBox.position = moveIt /*Vector3.right * movement * (speed / 50)*/;
            Vector3 moveIt = new Vector3(movement * (speed / 200), (bottom * howMuchDown), 0.0f);
            enemyBox.position = moveIt /*Vector3.right * movement * (speed / 50)*/;
        }








    }
}
