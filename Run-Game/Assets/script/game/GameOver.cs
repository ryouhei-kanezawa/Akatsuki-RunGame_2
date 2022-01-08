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

    private TextMeshProUGUI score;
    private TextMeshProUGUI coin;
    private Transform canvasTran;

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

        coin.text = coinCount.ToString();
        score.text = scoreCount.ToString();

        Time.timeScale = 0;
    }
}
