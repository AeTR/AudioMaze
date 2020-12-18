using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //print("left");
            var transform1 = transform;
            var position = transform1.position;
            transform.Translate(new Vector2(position.x - 1, position.y) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //print("right");print("left");
            var transform1 = transform;
            var position = transform1.position;
            transform.Translate(new Vector2(position.x + 1, position.y) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //print("up");print("left");
            var transform1 = transform;
            var position = transform1.position;
            transform.Translate(new Vector2(position.x, position.y + 1) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //print("down");print("left");
            var transform1 = transform;
            var position = transform1.position;
            transform.Translate(new Vector2(position.x, position.y - 1) * Time.deltaTime);
        }
    }
}
