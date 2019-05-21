using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Score score;
    public GameObject gameOver;

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
        
    }

    private void OnEnable()
    {
        Glass.OnGameOver += GameOver;
    }

    private void OnDisable()
    {
        Glass.OnGameOver -= GameOver;
    }

    void GameOver()
    {
        score.gameObject.SetActive(false);
        gameOver.SetActive(true);
    }
}
