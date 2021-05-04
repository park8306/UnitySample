using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);

        //animator.Play("GetHit", 0, 0);
        Destroy(other.gameObject);
        //animator.Play("GetHit");
        StartCoroutine(DieAndDestroy());
        
    }

    public float dieAnimationTime = 1f;

    private IEnumerator DieAndDestroy()
    {
        GetComponent<Collider>().enabled = false;
        enabled = false;
        animator.Play("Die");

        yield return new WaitForSeconds(dieAnimationTime);
        Destroy(gameObject);
    }

    public float speed = 3f;

    private void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
