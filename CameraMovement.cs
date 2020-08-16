using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Sources")]
    public Transform Player;
    
    [Header("Settings")]
    public float Sensitivity = 1f;
    private Vector3 _eular;
    [Header("RotationClampX")]
    public float MinMaxX = 40;
    //ignore
    private float Placeholder;
    private float Placeholder2;
    private float Placeholder3;
    [Header("Shake amount")]
    public float shakeRange;

    private void Start()
    {
  
        _eular.y = Player.transform.eulerAngles.y;

    }
      
    private void FixedUpdate()
    {

        Cursor.lockState = CursorLockMode.Locked;
        _eular.x -= Input.GetAxis("Mouse Y") * Sensitivity;
        _eular.y += Input.GetAxis("Mouse X") * Sensitivity;
        if (PlayerMovement.currentSpeed >= 20)
        {
            Placeholder = UnityEngine.Random.Range(0, shakeRange) * Time.fixedDeltaTime;
            Placeholder2 = UnityEngine.Random.Range(0, shakeRange) * Time.fixedDeltaTime;
            Placeholder3 = UnityEngine.Random.Range(0, shakeRange) * Time.fixedDeltaTime;
        }
        else
        {
            Placeholder = 0;
            Placeholder2 = 0;
            Placeholder3 = 0;
        }         if (PlayerMovement.currentSpeed >= 10)
        {
            Placeholder = (UnityEngine.Random.Range(0, shakeRange) * Time.fixedDeltaTime)*.3f;
            Placeholder2 = (UnityEngine.Random.Range(0, shakeRange) * Time.fixedDeltaTime) * .3f;
            Placeholder3 = (UnityEngine.Random.Range(0, shakeRange) * Time.fixedDeltaTime) * .3f;
        }
        else
        {
            Placeholder = 0;
            Placeholder2 = 0;
            Placeholder3 = 0;
        } 

        _eular.x = Mathf.Clamp(_eular.x, -MinMaxX, +MinMaxX);
       Player.eulerAngles = new Vector3(0f, _eular.y, 0f);
        transform.localEulerAngles = new Vector3(_eular.x + Placeholder, 0f + Placeholder2, 0f + Placeholder3);



    }

    }
