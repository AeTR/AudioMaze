using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public Room targetRoom;
    public Room[] roomsToReset;
    public Vector2 downPos, upPos, leftPos, rightPos;
    public bool upValid, leftValid, rightValid, downValid, firstTime, eventTrigger, noEvent;
    public Room upRoom, leftRoom, rightRoom, downRoom;
    public AudioClip upSound, downSound, leftSound, rightSound, ambientSound;
    public AudioClip roomAmbience, projectedAmbience1, projectedAmbience2, firstEnter, otherEnter;
    public AudioSource ambientSource, otherSource;

    // Start is called before the first frame update
    void Start()
    {
        firstTime = true;
        var position = transform.position;
        downPos = new Vector2(position.x, position.y - 5.5f);
        upPos = new Vector2(position.x, position.y + 5.5f);
        leftPos = new Vector2(position.x - 5.5f, position.y);
        rightPos = new Vector2(position.x + 5.5f, position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (eventTrigger && !otherSource.isPlaying)
        {
            MoveToRoom();
        }
    }

    public void EnterRoom()
    {
        if (!noEvent)
        {
            if (firstTime)
            {
                otherSource.PlayOneShot(firstEnter);
                firstTime = false;
            }
            else
            {
                otherSource.PlayOneShot(otherEnter);
            }
        }
    }

    public void ExitRoom()
    {
        ambientSource.clip = projectedAmbience2;
        ambientSource.Play();
    }

    public void MoveToRoom()
    {
        for (int i = 0; i < roomsToReset.Length; i++)
        {
            roomsToReset[i].ResetRoom();
        }
        targetRoom.EnterRoom();
        ExitRoom();
    }

    public void ResetRoom()
    {
        firstTime = true;
        ambientSource.clip = projectedAmbience1;
        ambientSource.Play();
    }
}
