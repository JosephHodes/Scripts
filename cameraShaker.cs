using System.Collections;

using UnityEngine;

public class cameraShaker : MonoBehaviour
{
    public float amount;
    public float duration;
    public float anything;
    public Transform cameraboi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PlayerMovement.currentSpeed > 15)
        {
           StartCoroutine(shakeAndbake(amount, duration));
            
        }
    }

    public IEnumerator shakeAndbake(float amount,float duration)
    {
        int random;
        random = Random.Range(0, 3);

        amount = PlayerMovement.currentSpeed / anything;
        if (random == 0)
        { 
            cameraboi.transform.Rotate(amount*Time.deltaTime, 0, 0);
           
        }
        if (random == 1)
        {
            cameraboi.transform.Rotate(0, 0, amount * Time.deltaTime);

        }
        if (random == 2)
        {
            cameraboi.transform.Rotate(0, amount * Time.deltaTime, 0);

        }

        yield return new WaitForSecondsRealtime(duration);
    }
}
