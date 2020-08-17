using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    private InputSystem IS;
    public SpringJoint springJoint;
    public float FireDistance;
    private CharacterController player;
    
    

    // Start is called before the first frame update
    void Start()
    {
        IS = FindObjectOfType<InputSystem>();
        player = FindObjectOfType<CharacterController>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(IS.Fire))
        {
            GrappleFire();
        }
        if (Input.GetKeyUp(IS.Fire))
        {
            GrappleRelease();
        }
    }
    private void GrappleFire()
    {

        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, FireDistance))
        {
            springJoint = player.gameObject.AddComponent<SpringJoint>();
            springJoint.anchor = hit.point;
            UnityEngine.Debug.Log( hit.distance +" "+hit.point+" "+hit.collider.gameObject);

        }
    }
    private void GrappleRelease()
    {
        springJoint.breakForce = 0;
    }
}
