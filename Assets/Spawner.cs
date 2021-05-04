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

        // ������ ���� �� ���� �ݺ�
        while(isPlaying)
        {
            int selectedIndex = Random.Range(0, points.Count);

            var selectedTranform = points[selectedIndex];
            Instantiate(EnemyGo, selectedTranform.position, EnemyGo.transform.rotation);

            yield return new WaitForSeconds(spawnDelay);
        }


        // ����
        // ������ ��ġ�� ����

        // ��� ����
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

        // �ڵ����� ���͸� �����ϱ� ���� �κ�(�̿�)
        // �Ƹ� �ڷ�ƾ�� ���鼭 3�� ��ٸ��ٰ� ��û���� ���� ��ٸ� �༮���� ��Ÿ���°� ����...
        // �ڷ�ƾ�� �ۿ��ٰ� �� ¥�ߵǳ�...??
        // �ƴϸ� if�� �ȿ� ������ �ٲ㺸��
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
