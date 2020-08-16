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
