using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRoom : MonoBehaviour
{
    public AudioClip roomAmbience, eventClip, upListen, downListen, leftListen, rightListen;

    public AudioSource centerSource, upSource, downSource, leftSource, rightSource, eventSource;

    public bool upValid, downValid, leftValid, rightValid, hasEvent, kills, occupied;

    public NewRoom upRoom, downRoom, leftRoom, rightRoom;

    public SpriteRenderer upGradient, downGradient, leftGradient, rightGradient;

    public NewRoomManager myManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        myManager = GameObject.Find("Room Manager").GetComponent<NewRoomManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadRoom()
    {
        Color upRoom = upGradient.color;
        Color downRoom = downGradient.color;
        Color leftRoom = leftGradient.color;
        Color rightRoom = rightGradient.color;
        //occupied = true;
        leftSource.panStereo = -0.75f;
        rightSource.panStereo = 0.75f;
        if (!upValid)
        {
            upRoom.a = 0f;
            upSource.mute = true;
        }
        else
        {
            print("up is a valid direction");
            upRoom.a = 0.5f;
            upSource.clip = upListen;
            upSource.volume = 0f;
            upSource.Play();
        }
        upGradient.color = upRoom;
        
        if (!downValid)
        {
            downRoom.a = 0f;
            downSource.mute = true;
        }
        else
        {
            downRoom.a = 0.5f;
            downSource.clip = downListen;;
            downSource.volume = 0f;
            downSource.Play();
        }
        downGradient.color = downRoom;
        
        if (!leftValid)
        {
            leftRoom.a = 0f;
            leftSource.mute = true;
        }
        else
        {
            leftRoom.a = 0.5f;
            leftSource.clip = leftListen;;
            leftSource.volume = 0f;
            leftSource.Play();
        }
        leftGradient.color = leftRoom;

        if (!rightValid)
        {
            rightRoom.a = 0f;
            rightSource.mute = true;
        }
        else
        {
            rightRoom.a = 0.5f;
            rightSource.clip = rightListen;;
            rightSource.volume = 0f;
            rightSource.Play();
        }
        rightGradient.color = rightRoom;
        
        centerSource.clip = roomAmbience;
        centerSource.volume = 0.7f;
        centerSource.Play();
        if (hasEvent)
        {
            eventSource.clip = eventClip;
            eventSource.volume = 1f;
            eventSource.Play();
        }
    }
}
