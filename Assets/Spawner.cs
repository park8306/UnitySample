using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<Transform> points;
    public GameObject EnemyGo;
    public float delaySpawn = 3.0f;

    public bool isPlaying = true;
    public float spawnDelay = 1f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        //int selectedIndex = Random.Range(0, points.Count);
        //Debug.Log(points[selectedIndex].position);

        // 게임이 끝날 때 까지 반복
        while(isPlaying)
        {
            int selectedIndex = Random.Range(0, points.Count);

            var selectedTranform = points[selectedIndex];
            Instantiate(EnemyGo, selectedTranform.position, EnemyGo.transform.rotation);

            yield return new WaitForSeconds(spawnDelay);
        }


        // 스폰
        // 랜덤한 위치에 스폰

        // 잠시 쉬기
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            int selectedIndex = Random.Range(0, points.Count);

            var selectedTranform = points[selectedIndex];
            Instantiate(EnemyGo, selectedTranform.position, EnemyGo.transform.rotation);
        }

        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    int selectedIndex = Random.Range(0, points.Count);

        //    var selectedTranform = points[selectedIndex];
        //    Instantiate(EnemyGo, selectedTranform.position, EnemyGo.transform.rotation);
        //}

        // 자동으로 몬스터를 생성하기 위한 부분(미완)
        // 아마 코루틴이 돌면서 3을 기다리다가 엄청나게 많이 기다린 녀석들이 나타나는거 같음...
        // 코루틴을 밖에다가 더 짜야되나...??
        // 아니면 if문 안에 조건을 바꿔보자
        //StartCoroutine(Spawn());
    }

    //private IEnumerator Spawn()
    //{

    //    yield return new WaitForSeconds(delaySpawn);
    //    int selectedIndex = Random.Range(0, points.Count);

    //    var selectedTranform = points[selectedIndex];

    //    Instantiate(EnemyGo, selectedTranform.position, EnemyGo.transform.rotation);
    //}

}
