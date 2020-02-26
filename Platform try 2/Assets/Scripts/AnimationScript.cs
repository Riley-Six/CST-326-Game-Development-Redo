using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PlayerLoop;

public class AnimationScript : MonoBehaviour
{

    public Animator animator;
    public Transform characterTransform;
    public Rigidbody rb;
    public float speed, jump;
    public bool onGround = false;



    // Start is called before the first frame update
    void Start(){
        //
    }

    enum AnimationParameters
    {
        move
    }

    // Update is called once per frame
    void Update(){
        //input, A and D
        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("move", speed);

        //Ethan Helped
        if (onGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jump;
        }

        animator.SetFloat(AnimationParameters.move.ToString(), Mathf.Abs(move));


    }


}
