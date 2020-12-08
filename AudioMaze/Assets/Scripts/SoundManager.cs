using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor.Build;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Room currentRoom;
    public AudioSource roomAmbienceA, roomAmbienceB, directionAmbience, activeSource, footstepsSource;
    public bool usingSourceA;
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
            if (myCheckState == CheckState.Up)
            {
                MoveBetweenRooms(currentRoom.upRoom);
            }
            else
            {
                if (currentRoom.upValid)
                {
                    myCheckState = CheckState.Up;
                    AdjustRoomAudio(false);
                    directionAmbience.clip = currentRoom.upSound;
                    Fade(directionAmbience, true);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (myCheckState == CheckState.Down)
            {
                MoveBetweenRooms(currentRoom.downRoom);
            }
            else
            {
                if (currentRoom.downValid)
                {
                    myCheckState = CheckState.Down;
                    AdjustRoomAudio(false);
                    directionAmbience.clip = currentRoom.downSound;
                    Fade(directionAmbience, true);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (myCheckState == CheckState.Left)
            {
                MoveBetweenRooms(currentRoom.leftRoom);
            }
            else
            {
                if (currentRoom.leftValid)
                {
                    myCheckState = CheckState.Left;
                    AdjustRoomAudio(false);
                    directionAmbience.clip = currentRoom.leftSound;
                    Fade(directionAmbience, true);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (myCheckState == CheckState.Right)
            {
                MoveBetweenRooms(currentRoom.rightRoom);
            }
            else
            {
                if (currentRoom.rightValid)
                {
                    myCheckState = CheckState.Right;
                    AdjustRoomAudio(false);
                    directionAmbience.clip = currentRoom.rightSound;
                    Fade(directionAmbience, true);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (myCheckState != CheckState.Center)
            {
                Fade(directionAmbience, false);
                AdjustRoomAudio(true);
            }
        }
    }

    public void MoveBetweenRooms(Room nextRoom)
    {
        Fade(directionAmbience, false);
        if (usingSourceA)
        {
            footstepsSource.clip = currentRoom.footstepsLeave;
            footstepsSource.Play();
            if (nextRoom.firstTime)
            {
                activeSource.clip = nextRoom.initialEnter;
                activeSource.PlayDelayed(currentRoom.footstepsLeave.length);
            }
            else
            {
                activeSource.clip = nextRoom.otherEnter;
            }
            activeSource.PlayDelayed(currentRoom.footstepsLeave.length);
            roomAmbienceB.clip = nextRoom.ambientSound;
            Fade(roomAmbienceA, false);
            Fade(roomAmbienceB, true);
            usingSourceA = false;
            myCheckState = CheckState.Center;
            currentRoom = nextRoom;
        }
        else
        {
            footstepsSource.clip = currentRoom.footstepsLeave;
            footstepsSource.Play();
            if (nextRoom.firstTime)
            {
                activeSource.clip = nextRoom.initialEnter;
                activeSource.PlayDelayed(currentRoom.footstepsLeave.length);
            }
            else
            {
                activeSource.clip = nextRoom.otherEnter;
            }
            activeSource.PlayDelayed(currentRoom.footstepsLeave.length);
            roomAmbienceA.clip = nextRoom.ambientSound;
            Fade(roomAmbienceB, false);
            Fade(roomAmbienceA, true);
            usingSourceA = true;
            myCheckState = CheckState.Center;
            currentRoom = nextRoom;
        }
        
    }

    public void Fade(AudioSource sourceToFade, bool fadeUp)
    {
        if (fadeUp)
        {
            //will be something different
            sourceToFade.Play();
        }
        else
        {
            //will be something different
            sourceToFade.Stop();
        }
    }

    public void AdjustRoomAudio(bool turningUp)
    {
        if (turningUp)
        {
            if (usingSourceA)
            {
                
            }
            else
            {
                
            }
        }
        else
        {
            if (usingSourceA)
            {
                
            }
            else
            {
                
            }
        }
    }
}
