using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayerMovingGO : MonoBehaviour
{

    public Transform player;
    public float speed, leftWall, rightWall, playerAxis;
    //private float stationary = 0;
    public GameObject bullet;
    public Transform shottingOffset;
    private Animator playerAnimator;
    //public AudioSource pewpew;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform> ();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        playerAxis = Input.GetAxis("playerLandR");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnimator.SetTrigger("Fire!");
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            //Debug.Log("Bang!");
            //pewpew.Play();

            Destroy(shot, 3f);

        }
        
    }



    void FixedUpdate()
    {





        float stopper = 0;
        playerAxis = Input.GetAxis("playerLandR");

        if (player.position.x < leftWall && playerAxis < 0)
        {
            playerAxis = 0;
        }
        else if (player.position.x > rightWall && playerAxis > 0)
        {
            playerAxis = 0;
        } else if (playerAxis == 0)
        {
            player.position += Vector3.right * speed * playerAxis * stopper;
            shottingOffset.Translate(Vector3.right * speed * playerAxis * stopper);
        } else
        {
            player.position += Vector3.right * speed * playerAxis;
            shottingOffset.Translate(Vector3.right * speed * playerAxis);
        }

        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Animator>().SetTrigger("Death");
    }

}



