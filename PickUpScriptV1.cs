using UnityEngine;


public class PickUpScriptV1 : MonoBehaviour
{
  /*  public GameObject GunNode;
    public GameObject bulletPrefab;

    public bool IsHoldingGun = false;
    public Transform BulletHolder;
    public Rigidbody BulletPlaceHolder;
    public GameMangaer Mangaer;

    public uint bulletSpeed;
    public int multiplicationFactor;

    public DodgeBall CurrentBall = null;



    private void OnTriggerStay(Collider other)
    {

        DodgeBall g = other.GetComponent<DodgeBall>();

        if (!g)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ThrowBall();
            PickupBall(g);
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            ThrowBall();

        }
    }



    private void ThrowBall()
    {

        // if not holding gun so it returns back
        
        if (!CurrentBall)
            return;

        CurrentBall.GetComponent<MeshCollider>().enabled = true;
        CurrentBall.GetComponent<Rigidbody>().isKinematic = false;
        CurrentBall.transform.parent = null;
        CurrentBall.GetComponent<Rigidbody>().AddForce(CurrentBall.transform.forward * 1500f);
        CurrentBall = null;
        Mangaer.isHoldingBall = false;

    }

    void PickupBall(DodgeBall gun)
    {

        gun.transform.parent = GunNode.transform;
        gun.transform.localPosition = Vector3.zero;
        gun.transform.localRotation = Quaternion.identity;
        gun.GetComponent<MeshCollider>().enabled = false;
        gun.GetComponent<Rigidbody>().isKinematic = true;
        CurrentBall = gun;
        Mangaer.isHoldingBall = true;
    }*/
}