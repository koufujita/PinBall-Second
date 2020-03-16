using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
    //スコアを表示するテキスト
    private GameObject scoreText;
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        //変数の宣言
        int score;
        score = 0;
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");


    }
    void OnCollisionEnter(Collision other)
    {
        SetScore(score);


        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;

        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 20;
        }

    }

    void SetScore(int score)
    {
        this.scoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
        Debug.Log(tag);
    }
}