using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public float score,hasil;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("highscore");
        score = 0;
        hasil = 0;
        ScoreText.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            SaveLoadHighScore.SaveHighScore(score);
            ScoreText.text = "Score : "+((int)score).ToString();
        }
        hasil = score;
        
        Debug.Log("Score Anda : " + ((int)hasil).ToString());   
    }
}
