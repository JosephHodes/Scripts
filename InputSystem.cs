using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public KeyCode MoveFoward = KeyCode.W;
    public KeyCode MoveBackwards = KeyCode.S;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveRight = KeyCode.D;
    public KeyCode Sprint = KeyCode.LeftShift;
    public KeyCode Jump = KeyCode.Space;
   


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }
}
