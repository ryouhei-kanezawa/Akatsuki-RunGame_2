using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject over;
    [SerializeField]
    private CoinSet _coin;

    public void Overset()
	{
        Time.timeScale = 0;

        _coin.StopSwich(false);
        GameObject game = Instantiate(over);
	}
}
