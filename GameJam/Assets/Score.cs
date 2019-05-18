using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = "SCORE: " + score;
    }

    private void OnEnable()
    {
        Glass.OnClickRightGlass += UpdateScore;
    }

    private void OnDisable()
    {
        Glass.OnClickRightGlass -= UpdateScore;
    }

    void UpdateScore()
    {
        score++;
        GetComponent<TextMesh>().text = "SCORE: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
