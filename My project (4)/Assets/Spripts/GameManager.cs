using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerController player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject getReady;
    private int score = 0;
    private void Awake() {
        Application.targetFrameRate = 60;

        GetReady();
    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        getReady.SetActive(false);

        player.enabled = true;
        Time.timeScale = 1f;

        Obstacle[] pipes = FindObjectsOfType<Obstacle>();
        for (int i = 0; i < pipes.Length; i++ ) {
            Destroy(pipes[i].gameObject);
        }

    }
    public void GetReady()
    {
        player.enabled = false;
        Time.timeScale = 0f;
        playButton.SetActive(true);
        getReady.SetActive(true);
        gameOver.SetActive(false);
    }
    public void Pause()
    {
        player.enabled = false;
        Time.timeScale = 0f;
        playButton.SetActive(true);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(false);
        Pause();
        Debug.Log("Game Over");
    }

    public void Increasescore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
    
}
