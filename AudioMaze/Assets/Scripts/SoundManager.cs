using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor.Build;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public Room currentRoom;
    public enum CheckState
    {
        Center,
        Left,
        Down,
        Right,
        Up
    }
    public CheckState myCheckState;
    
    // Start is called before the first frame update
    void Start()
    {
        myCheckState = CheckState.Center;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector2.Lerp(transform.position, currentRoom.upPos, 0.5f);
            if (currentRoom.upValid)
            {
                if (myCheckState == CheckState.Up)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentRoom.downValid)
            {
                if (myCheckState == CheckState.Down)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentRoom.leftValid)
            {
                if (myCheckState == CheckState.Left)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentRoom.rightValid)
            {
                if (myCheckState == CheckState.Right)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                
            }
        }
    }
    
    
}
