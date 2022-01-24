using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUpdate
{
	public static bool gameSwich;
	public static bool backSwich;

	public bool GetGameSwich()
	{
		return gameSwich;
	}

	public void SetGameSwich(bool tmp)
	{
		gameSwich = tmp;
	}
	public bool GetBackSwich()
	{
		return backSwich;
	}

	public void SetBackSwich(bool tmp)
	{
		backSwich = tmp;
	}
}
