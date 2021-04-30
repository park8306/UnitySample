using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // WASD, W위로, A왼쪽, S 아래, D 오른쪽
        float moveX = 0;    // 옆
        float moveZ = 0;    // 앞


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveZ = 1;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveZ = -1;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveX = -1;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveX = 1;
        }

        Vector3 position = transform.position;

        position.x += moveX * speed * Time.deltaTime;
        position.z += moveZ * speed * Time.deltaTime;

        transform.position = position;

    }
}
