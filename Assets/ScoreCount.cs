using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class ScoreCount : MonoBehaviour
{


    public int myscore = 1;
     //TextMeshPro  ScoreText;
    public Text text;

    private void Start()
    {
        myscore = 0;
      // ScoreText = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        text.text= myscore.ToString();
    }

   /* public void AddScore(int scores)
    {
        myscore = myscore + scores;
    }*/
}
