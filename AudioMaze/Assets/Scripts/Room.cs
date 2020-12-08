using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public bool upValid, leftValid, rightValid, downValid, firstTime;
    public Room upRoom, leftRoom, rightRoom, downRoom;
    public AudioClip upSound, downSound, leftSound, rightSound, ambientSound;
    public AudioClip initialEnter, otherEnter, footstepsLeave;

    // Start is called before the first frame update
    void Start()
    {
        firstTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
