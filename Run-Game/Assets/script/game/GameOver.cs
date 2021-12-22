using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject over;            //Instantiate‚·‚éobject
    [SerializeField]
    private CoinSet _coin;
    [SerializeField]
    private GameObject canvas;          //Instantiate‚·‚éCanvas


    private TextMeshProUGUI score;
    private TextMeshProUGUI coin;
    private Transform canvasTran;

    public void Overset()
	{
        _coin.StopSwich(false);
        GameObject game = Instantiate(over, canvasTran, false);
        game.transform.SetParent(canvas.transform, false);

        coin = over.transform.Find("coinText").GetComponent<TextMeshProUGUI>();
        score=over.transform.Find("scoreText").GetComponent<TextMeshProUGUI>();

        _coin.TextUpdate(coin, score);

        Time.timeScale = 0;
    }
}
