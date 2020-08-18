using Photon.Realtime;
using UnityEngine;
using Photon;
using Photon.Pun;

public class NetworkHandler : MonoBehaviourPunCallbacks
{
    public MeshFilter meshFilters;
    public MeshRenderer meshRenderers;
    public PlayerMovement playerz;
    public CapsuleCollider colliders;
    public Rigidbody rigidbodyz;
    public PickUpScript Pick;
    public Camera camersa;
    // Start is called before the first frame update
    void Awake()
    {
        
        if (photonView.IsMine)
        {

        }
        else
        {
            Destroy(Pick);
            Destroy(colliders);
            Destroy(rigidbodyz);
            Destroy(playerz);
            Destroy(camersa);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
