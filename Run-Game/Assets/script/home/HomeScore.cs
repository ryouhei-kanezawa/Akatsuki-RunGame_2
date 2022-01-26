
public class HomeScore
{
	public static int scoreBox = -1;
	public static int coin = 0;
	public static int kyori = 0;

	public int GetCoin
	{
		set
		{
			coin = value;
		}

		get
		{
			return coin;
		}
	}

	public int GetKyori
	{
		set
		{
			kyori = value;
		}

		get
		{
			return kyori;
		}
	}

	public void SetScore(int temp)
	{
		scoreBox = temp;
	}

	public int GetScore()
	{
		return scoreBox;
	}
}
