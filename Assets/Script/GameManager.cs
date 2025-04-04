using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;
    public GameObject EndPanel;

    public Text TotalScoreTxt;
    public Text timeTxt;


    int totalScore;
    float totalTime = 5.0f;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
    }
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
    }

    void Update()
    {
        if (totalTime > 0f)
        {
            totalTime -= Time.deltaTime;
        }
        else
        {
            totalTime = 0f;
            EndPanel.SetActive(true);
            Time.timeScale = 0f;
        }

        timeTxt.text = totalTime.ToString("##.##"); //N2, D2
    }

    void MakeRain()
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        TotalScoreTxt.text = totalScore.ToString();
    }
}
