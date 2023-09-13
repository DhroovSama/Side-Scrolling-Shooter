using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    Text txt;
    public int score = 0;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    public void AddToScoreVOID()
    {
        score = score + 1;
        printScore();
    }

    public void printScore()
    {
        txt.text = "Score: " +score;
    }
}
