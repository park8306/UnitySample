using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public GameObject arrow;
    public Transform arrowSpawnPosition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            // �ַο츦 �߻�., �����ϴ� �ڵ�
            Instantiate(arrow, arrowSpawnPosition.position, arrowSpawnPosition.rotation);
        }
    }
}
