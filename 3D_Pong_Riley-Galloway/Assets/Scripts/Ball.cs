using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 4f;
    public float faster = 0.5f;
    public int redPoints = 0;
    public int bluePoints = 0;


    // Start is called before the first frame update
    void Start()
    {
        float initialDirectionX = Random.Range(0, 2) == 0 ? -1 : 1;
        float initialDirectionZ = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * initialDirectionX, 0f, speed * initialDirectionZ);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Left Paddle")
        {
            Debug.Log("Left Paddle Bonk");
        }
        if (collision.gameObject.tag == "Right Paddle")
        {
            Debug.Log("Right Paddle Bonk");
        }
        if (collision.gameObject.tag == "Left Goal")
        {
            Debug.Log("Left Goal Bop");
            bluePoints += 1;
            if(bluePoints == 10)
            {
                Debug.Log("Left Goal win");
            }
            Debug.Log("Points 2 : " + bluePoints);


        }
        if (collision.gameObject.tag == "Right Goal")
        {
            Debug.Log("Right Goal Bop");
            redPoints += 1;
            Debug.Log("Points 1 : " + redPoints);


        }
    }
}
*/



public class Ball : MonoBehaviour
{

    [SerializeField] private float amplitude;
    [SerializeField] private float step;
    private float startAmplitude;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        startAmplitude = amplitude;
    }

    // Update is called once per frame
    public void Restart()
    {
        amplitude = startAmplitude;
        rb.MovePosition(Vector3.zero);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude; // change to send to losing side
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Left Paddle" || collision.gameObject.name == "Right Paddle")
        {
            //play sound

            amplitude += step;
            float offset = Mathf.Pow((transform.position.z - collision.transform.position.z), 2);
            offset = (transform.position.z - collision.transform.position.z < 0) ? offset * -1 : offset;

            rb.velocity = (collision.gameObject.name == "PaddleLeft")
                ? new Vector3(amplitude, 0, offset)
                : new Vector3(-amplitude, 0, offset);
        }


    }


}