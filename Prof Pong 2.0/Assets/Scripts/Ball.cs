using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float amplitude;
    [SerializeField] private float step;
    [SerializeField] private Goal leftGoal;
    [SerializeField] private Goal rightGoal;
    [SerializeField] private PowerUp top;
    [SerializeField] private PowerUp bottom;


    private float startAmplitude;
    private float random;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        startAmplitude = amplitude;
    }

    // Update is called once per frame
    public void Start()
    {
        //amplitude = startAmplitude * Random.Range(0, 2) == 0 ? -1 : 1;
        rb.MovePosition(Vector3.zero);
        random = Random.Range(0, 2) == 0 ? -1 : 1;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * startAmplitude * random;
    }

    public void PowerUp(PowerUp torb)
    {
        rb.MovePosition(Vector3.zero);
        if(torb == top)
        {
            rb.MovePosition(Vector3.zero);
            random = Random.Range(0, 2) == 0 ? -1 : 1;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude * random * 2.0f;
        }
        if(torb == bottom)
        {
            rb.MovePosition(Vector3.zero);
            random = Random.Range(0, 2) == 0 ? -1 : 1;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude * random * 0.5f;
        }

    }


    public void Restart(Goal goal)
    {
        Debug.Log("Ball");
        if (goal == leftGoal){
            amplitude = startAmplitude * -1;
            Debug.Log("Ball left");
        }
        else
        {
            amplitude = startAmplitude;
            Debug.Log("Ball right");
        }
        rb.MovePosition(Vector3.zero);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude;
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "PaddleLeft" || collision.gameObject.name == "PaddleRight")
        {
            //play sound

            amplitude = amplitude * step;
            float offset = Mathf.Pow((transform.position.z - collision.transform.position.z), 2);
            offset = (transform.position.z - collision.transform.position.z < 0) ? offset * -1 : offset;

            if(collision.gameObject.name == "PaddleLeft")
            {
                rb.velocity = new Vector3(amplitude, 0, offset);
            }
            else
            {
                rb.velocity = new Vector3(-amplitude, 0, offset);
            }
            /* 
             rb.velocity = (collision.gameObject.name == "PaddleLeft")
                ? new Vector3(amplitude, 0, offset)
                : new Vector3(-amplitude, 0, offset);
             */
            
        }
        

    }


}
