using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<Transform> points;
    public GameObject EnemyGo;
    public float delaySpawn = 3.0f;
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

        //StartCoroutine(Spawn());
    }

    //private IEnumerator Spawn()
    //{
    //    int selectedIndex = Random.Range(0, points.Count);

    //    var selectedTranform = points[selectedIndex];
        

    //    yield return new WaitForSeconds(delaySpawn);

    //    Instantiate(EnemyGo, selectedTranform.position, EnemyGo.transform.rotation);
    //}
    
}
