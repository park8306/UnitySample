using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOHelper : MonoBehaviour
{
    public float delayDestroy;
    // Start is called before the first frame update
    void Start()
    {
        if (delayDestroy > 0)
        {
            Destroy(gameObject, delayDestroy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
