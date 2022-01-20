using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject over;            //Instantiate‚·‚éobject
    [SerializeField]
    private ScoreManager _score;
    [SerializeField]
    private GameObject canvas;          //Instantiate‚·‚éCanvas
    [SerializeField]
    private PlayBGM sound;

    private TextMeshProUGUI score;
    private TextMeshProUGUI coin;
    private Transform canvasTran;
    private HomeScore home = new HomeScore();

    private int coinCount = 0;
    private int scoreCount = 0;

	private void Update()
	{
        coinCount = _score.CoinScore;
        scoreCount = _score.KyoriScore;
    }

	public void Overset()
	{
        _score.StopSwich(false);
        GameObject game = Instantiate(over, canvasTran, false);
        game.transform.SetParent(canvas.transform, false);

        coin = game.transform.Find("coinText").GetComponent<TextMeshProUGUI>();
        score = game.transform.Find("scoreText").GetComponent<TextMeshProUGUI>();

        coin.text = "coin:" + coinCount;
        score.text = "score:" + scoreCount;

        home.SetScore(scoreCount);
        sound.StopSound();

        Time.timeScale = 0;
    }
}
