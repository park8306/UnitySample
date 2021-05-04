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
        // ��ŸƮ �Լ��� ������
        // ����Ǵ� ������ �� ������.
        // ���ӿ�����Ʈ�� ���� ������ �ٷ� ����ȴ�.
        instance = this;
        //score = int.Parse(scoreText.text.Replace("score : ",""));
    }

    public void AddScore(int addPoint)
    {
        score += addPoint;

        scoreText.text = "Score : " + score.ToString();
        // UI�� �ݿ�
    }
}
