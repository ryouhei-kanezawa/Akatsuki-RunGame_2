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

	public void Overset()
    {

        _score.StopSwich(false);
        GameObject game = Instantiate(over, canvasTran, false);
        game.transform.SetParent(canvas.transform, false);

        coin = game.transform.Find("coinText").GetComponent<TextMeshProUGUI>();
        score = game.transform.Find("scoreText").GetComponent<TextMeshProUGUI>();

        coin.text = "coin:" + _score.CoinScore;
        score.text = "score:" + _score.KyoriScore;

        home.SetScore(_score.KyoriScore);
        sound.StopSound();

        Time.timeScale = 0;
    }
}
