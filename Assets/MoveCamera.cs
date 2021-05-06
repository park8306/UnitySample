using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 dif;
    Vector3 v3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v3 = player.transform.position;
        dif = transform.position - v3;

        Debug.Log(dif);

        transform.position = v3 + dif;
    }
}
