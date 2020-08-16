using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody RB;
    private InputSystem IS;
    [Header("Movement")]
    public static float currentSpeed;
    public float runSpeed;
    public float walkSpeed;
    public bool grounded;
    public LayerMask ground;
    public float BhopSpeed;

    [Header("Gravity")]
    public float normalGravity;
    public float fallingGravity;
    public float gravity;
    public float JumpHeight;

    void Start()
    {
        IS = FindObjectOfType<InputSystem>();
        RB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        currentSpeed = RB.velocity.magnitude;
        Debug.Log(RB.velocity.magnitude);
        if (Input.GetKey(IS.MoveFoward) && Input.GetKey(IS.Sprint)) { RB.AddForce(transform.forward * runSpeed); }
        else if (Input.GetKey(IS.MoveFoward)) { RB.AddForce(transform.forward * walkSpeed); }
        if (Input.GetKey(IS.MoveBackwards)) { RB.AddForce(transform.forward * -walkSpeed); }
        if (Input.GetKey(IS.MoveRight)) { RB.AddForce(transform.right * walkSpeed); }
        if (Input.GetKey(IS.MoveLeft)) { RB.AddForce(transform.right * -walkSpeed); }
        if (Input.GetKey(IS.Jump) && grounded) { RB.AddForce(transform.up * JumpHeight);
        }
        if (!grounded)
        {
            RB.AddForce(transform.up * -gravity);

            if (Input.GetKey(IS.MoveRight) && Input.GetKey(IS.MoveLeft))
            {
                RB.AddForce(transform.forward * (BhopSpeed*currentSpeed));

            } else {
                if (Input.GetKey(IS.MoveFoward)) {
                    RB.AddForce(transform.forward * (BhopSpeed * currentSpeed));

                }
                if (Input.GetKey(IS.MoveRight))
                {
                    RB.AddForce(transform.forward * (BhopSpeed * currentSpeed));

                }
                if (Input.GetKey(IS.MoveLeft))
                {
                    RB.AddForce(transform.forward * (BhopSpeed * currentSpeed));

                }
            }
        } 
    }
        }

