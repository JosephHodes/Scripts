using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
    using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody RB;
    [HideInInspector]
    public int BoostSpeed;
    private InputSystem IS;
    private float jumpamount;
    public int Speedboost;
    [Header("Movement")]
    public static float currentSpeed;
    public float runSpeed;
    public float walkSpeed;
    public bool grounded;
    public LayerMask ground;
    public float BhopSpeed;
    public bool abletodoublejump;
    public float doublejumpForce;

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
        if (grounded)
        {
            
        }
        currentSpeed = RB.velocity.magnitude;
        Debug.Log(RB.velocity.magnitude);
        if (Input.GetKey(IS.MoveFoward) && Input.GetKey(IS.Sprint)) { RB.AddForce(transform.forward * (runSpeed + Speedboost)); }
        else if (Input.GetKey(IS.MoveFoward)) { RB.AddForce(transform.forward * (walkSpeed + Speedboost)); }
        if (Input.GetKey(IS.MoveBackwards)) { RB.AddForce(transform.forward * -(walkSpeed + Speedboost)); }
        if (Input.GetKey(IS.MoveRight)) { RB.AddForce(transform.right * (walkSpeed+Speedboost)); }
        if (Input.GetKey(IS.MoveLeft)) { RB.AddForce(transform.right * -(walkSpeed + Speedboost)); }
        if (Input.GetKey(IS.Jump) && grounded) {jumpamount++; RB.AddForce(transform.up * JumpHeight);if (abletodoublejump) { jumpamount++; RB.AddForce(transform.up*doublejumpForce } }
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

