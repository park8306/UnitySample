using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    public int score;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        // 스타트 함수랑 차이점
        // 실행되는 순서가 더 빠르다.
        // 게임오브젝트가 씬에 나오면 바로 실행된다.
        instance = this;
        //score = int.Parse(scoreText.text.Replace("score : ",""));
    }

    public void AddScore(int addPoint)
    {
        score += addPoint;

        scoreText.text = "Score : " + score.ToString();
        // UI에 반영
    }
}
