using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    private InputSystem IS;
    public SpringJoint springJoint;
    public float FireDistance, forwardSpeed;
    public GameObject player;
    public bool IsSpringAlive;
    private PickUpScript pickup;
    private Vector3 distancebetweenu;
    private float placeholder;

    // Start is called before the first frame update
    void Start()
    {
        IS = FindObjectOfType<InputSystem>();
        pickup = FindObjectOfType<PickUpScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pickup.isholdingGun)
        {
            if (Input.GetKeyDown(IS.Fire))
            {
                GrappleFire();

            }
            if (Input.GetKeyUp(IS.Fire))
            {
                if (IsSpringAlive)
                {

                    Destroy(springJoint); 
                    GrappleRelease();
                    
                }
            }
            if (IsSpringAlive)
            {
                springJoint.anchor = (distancebetweenu * placeholder) * .25f;
            }
        }
    }
    private void GrappleFire()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.forward, out hit, FireDistance))
        {
            springJoint = player.gameObject.AddComponent<SpringJoint>();
            springJoint.anchor = hit.point;
            UnityEngine.Debug.Log( hit.distance +" "+hit.point+" "+hit.collider.gameObject);
            IsSpringAlive = true;
            player.GetComponent<Rigidbody>().AddForce(transform.forward * forwardSpeed);
            distancebetweenu = hit.point;
            placeholder = hit.distance;
        }
    }
    private void GrappleRelease()
    {
        IsSpringAlive = false;
    }
}
