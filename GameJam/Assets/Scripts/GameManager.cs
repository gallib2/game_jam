using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Score score;
    public GameObject gameOver;
    public GameObject levelSuccess;

    private void Awake()
    {
        gameOver.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (score.score <= 0)
        {
            LevelSuccess();
        }
    }

    private void OnEnable()
    {
        Glass.OnGameOver += GameOver;
    }

    private void OnDisable()
    {
        Glass.OnGameOver -= GameOver;
    }

    void LevelSuccess()
    {
        score.gameObject.SetActive(false);
        levelSuccess.SetActive(true);
    }

    void GameOver()
    {
        score.gameObject.SetActive(false);
        gameOver.SetActive(true);
    }
}
