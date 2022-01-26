using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
	[SerializeField]
	private Text scoreText;
	[SerializeField]
	private Text coinText;
	[SerializeField]
	private Text maxText;

	public void SetText(int score,int coin,int max)
	{
		scoreText.text = score.ToString();
		coinText.text = coin.ToString();
		maxText.text = max.ToString();
	}
}
