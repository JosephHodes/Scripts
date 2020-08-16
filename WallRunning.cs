
using UnityEngine;

public class WallRunning : MonoBehaviour
{

    public LayerMask layer;
    [Header("wallRunning stuff")]
    public float speed;
    public float speedUp;
    public float jumpForce;
    public float jumpFowardForce;
    public float WallGravity;
    public Rigidbody Rb;
    public bool iswallrunningRight;
    public bool iswallrunningLeft;
    private InputSystem IS;
    private int placeholder1;
    private int placeholder2;
    private float placeholder3;
    private float placeholder4;

    private void Start()
    {
        IS = FindObjectOfType<InputSystem>();
        placeholder3 = speed;
        placeholder4 = speedUp;
    }
    public void FixedUpdate()
    {
        if (iswallrunningLeft)
        {
            if (placeholder1 == 0)
            {
                speedUp = placeholder4;
                speed = placeholder3;

                placeholder1++;
                Invoke("MoveBoy", 0.1f);
                Invoke("Downward", 0.3f);
                Invoke("Stop", 0.4f);
                if (Input.GetKeyDown(IS.Jump))
                {
                    Rb.AddForce(transform.forward * jumpFowardForce);
                    Rb.AddForce(transform.up * jumpForce);
                    Rb.AddForce(-transform.right*jumpForce);
                }

            }else
            {
                placeholder1--;
            }
        }
        
        if (iswallrunningRight)
        {
            if (placeholder2 == 0)
            {
                placeholder2++;
                Invoke("MoveBoy", 0.1f);
                Invoke("Downward", 0.3f);
                Invoke("Stop", 0.4f);
                if (Input.GetKeyDown(IS.Jump))
                {
                    Rb.AddForce(transform.forward * jumpFowardForce);
                    Rb.AddForce(transform.up * jumpForce);
                    Rb.AddForce(transform.right * jumpForce);

                }

            }
            else
            {
                placeholder2--;
            }
        }
    }

    private void MoveBoy() {
        Rb.AddForce(transform.forward * speed);
        Rb.AddForce(transform.up * speedUp);
    }
    private void Downward()
    {
        Rb.AddForce(transform.up * -WallGravity);
        speed = 0;
        speedUp = 0;
    }
    private void Stop()
    {
        iswallrunningLeft = false;
        iswallrunningRight = false;
    }
}
