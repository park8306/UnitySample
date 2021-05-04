using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<Transform> points;
    public GameObject EnemyGo;
    // Start is called before the first frame update
    void Start()
    {
        int selectedIndex = Random.Range(0, points.Count);
        Debug.Log(points[selectedIndex].position);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            int selectedIndex = Random.Range(0, points.Count);

            var selectedTranform = points[selectedIndex];
            Instantiate(EnemyGo, selectedTranform.position, EnemyGo.transform.rotation);
        }
    }
    // Update is called once per frame
}
