using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public GameObject arrow;
    public Transform arrowSpawnPosition;

    public Animator animator;

    // 지정한 시간 간격으로 Projectile 발사

    public float interval = 0.5f;

    public float FireDelay = 0.2f;

    private IEnumerator Start()
    {
        while (true)
        {
            StartCoroutine(OnFireArrow());
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            // 애로우를 발사., 생성하는 코드
            StartCoroutine(OnFireArrow());
        }
    }

    private IEnumerator OnFireArrow()
    {
        //어택 액션 진행
        animator.Play("Attack01", 0, 0);
        // 잠시 쉬었다가
        yield return new WaitForSeconds(FireDelay);
        // 애로우를 발사.
        Instantiate(arrow, arrowSpawnPosition.position, arrowSpawnPosition.rotation);
    }
}
