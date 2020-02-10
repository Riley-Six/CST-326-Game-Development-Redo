using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
// opopopopopopopopopopopopopopop



public class Ball : MonoBehaviour
{

    [SerializeField] private float amplitude;
    [SerializeField] private float step;
    [SerializeField] private Goal leftGoal;
    [SerializeField] private Goal rightGoal;
    [SerializeField] private PowerUp top;
    [SerializeField] private PowerUp bottom;
    private float startAmplitude;


    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        float rORl = Random.Range(0, 2) == 0 ? -1 : 1;
        startAmplitude = amplitude;
    }

    // Update is called once per frame
    public void Start()
    {
        float rORl = Random.Range(0, 2) == 0 ? -1 : 1;
        amplitude = startAmplitude * rORl;
        rb.MovePosition(Vector3.zero);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude; // change to send to losing side
    }

    public void Restart(Goal goal)
    {

        if(goal == leftGoal)
        {
            amplitude = startAmplitude * -1;
        }
        else
        {
            amplitude = startAmplitude;
        }

        rb.MovePosition(Vector3.zero);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude; // change to send to losing side
    }

    public void RestartPowerUp(PowerUp zzz)
    {
        float rORl = Random.Range(0, 2) == 0 ? -1 : 1;

        if(zzz = top)
        {
            amplitude = startAmplitude * rORl * 2.0f;
            rb.MovePosition(Vector3.zero);
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude;
        } 
        else 
        {
            amplitude = startAmplitude * rORl * 0.5f;
            rb.MovePosition(Vector3.zero);
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude;
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "PaddleLeft" || collision.gameObject.name == "PaddleRight")
        {
            //play sound

            amplitude = amplitude * step;
            float offset = Mathf.Pow((transform.position.z - collision.transform.position.z), 2);
            offset = (transform.position.z - collision.transform.position.z < 0) ? offset * -1 : offset;

            rb.velocity = (collision.gameObject.name == "PaddleLeft")
                ? new Vector3(amplitude, 0, offset)
                : new Vector3(-amplitude, 0, offset);
        }
        

    }


}

