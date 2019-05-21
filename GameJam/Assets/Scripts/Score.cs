using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int initial_score;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        initial_score = Random.Range(10,20);
        score += initial_score;
        string text = "DRINKS REMAINING: " + score;
        SetText(text);
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
        score--;

        string text = "DRINKS REMAINING: " + score;
        SetText(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetText(string text)
    {
        GetComponent<TextMesh>().text = text;
    }



}
