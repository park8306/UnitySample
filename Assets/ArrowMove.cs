using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.z = position.z + speed * Time.deltaTime;
        transform.position = position;
    }
}
