using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    [Header("Hit Length")]
    public float lengthCast = .1f;
    public float lengthCastWall;
    private PlayerMovement PMS;
    private WallRunning Jumpboy;

    private void Start()
    {
        PMS = FindObjectOfType<PlayerMovement>();
        Jumpboy = FindObjectOfType<WallRunning>();
        InvokeRepeating("Checker", 0.1f, 0.1f);
    }
    void Checker()
    {
        //bellow ground checker
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, lengthCast))
        {
            PMS.grounded = true;
            Debug.DrawLine(transform.position, transform.position + (-transform.up * lengthCast), Color.blue);
        }
        else
        {
            PMS.grounded = false;
        }
        
        if (Physics.Raycast(transform.position, transform.right, out hit, lengthCastWall))
        {
            Jumpboy.iswallrunningRight = true;
            Debug.DrawLine(transform.position, transform.position + (-transform.right * lengthCastWall), Color.blue);
        }
        else if (Physics.Raycast(transform.position, -transform.right, out hit, lengthCastWall))
        {
            Jumpboy.iswallrunningLeft = true;
            Debug.DrawLine(transform.position, transform.position + (transform.right * lengthCastWall), Color.blue);
        }
        else
        {
            Jumpboy.iswallrunningRight = false;
            Jumpboy.iswallrunningLeft = false;
        
        }
    }



    }
