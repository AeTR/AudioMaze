using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRoomManager : MonoBehaviour
{
    public NewRoom currentRoom;
    
    public bool movable;

    public enum RoomPosition
    {
        Center,
        Left,
        Right,
        Up,
        Down
    }
    public RoomPosition roomPos;
    // Start is called before the first frame update
    void Start()
    {
        roomPos = RoomPosition.Center;
        print("loading room");
        currentRoom.LoadRoom();
    }

    // Update is called once per frame
    void Update()
    {
        if (movable)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && currentRoom.upValid)
            {
                print("going up");
                Color temp1 = currentRoom.upGradient.color;
                Color temp2;
                switch (roomPos)
                {
                    case RoomPosition.Center:
                        currentRoom.centerSource.volume = 0.25f;
                        currentRoom.upSource.volume = 0.75f;
                        temp1.a = 0.75f;
                        currentRoom.upGradient.color = temp1;
                        break;
                    case RoomPosition.Up:
                        MoveRooms(currentRoom.upRoom);
                        break;
                    case RoomPosition.Down:
                        currentRoom.downSource.volume = 0f;
                        currentRoom.upSource.volume = 0.75f;
                        break;
                    case RoomPosition.Right:
                        currentRoom.rightSource.volume = 0f;
                        currentRoom.upSource.volume = 0.75f;
                        break;
                    case RoomPosition.Left:
                        currentRoom.leftSource.volume = 0f;
                        currentRoom.upSource.volume = 0.75f;
                        break;
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && currentRoom.downValid)
            {
                switch (roomPos)
                {
                    case RoomPosition.Center:
                        break;
                    case RoomPosition.Up:
                        break;
                    case RoomPosition.Down:
                        break;
                    case RoomPosition.Right:
                        break;
                    case RoomPosition.Left:
                        break;
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) && currentRoom.leftValid)
            {
                switch (roomPos)
                {
                    case RoomPosition.Center:
                        break;
                    case RoomPosition.Up:
                        break;
                    case RoomPosition.Down:
                        break;
                    case RoomPosition.Right:
                        break;
                    case RoomPosition.Left:
                        break;
                }
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) && currentRoom.rightValid)
            {
                switch (roomPos)
                {
                    case RoomPosition.Center:
                        break;
                    case RoomPosition.Up:
                        break;
                    case RoomPosition.Down:
                        break;
                    case RoomPosition.Right:
                        break;
                    case RoomPosition.Left:
                        break;
                }
            }
            
        }
    }

    public void MoveRooms(NewRoom target)
    {
        
    }
    
}
