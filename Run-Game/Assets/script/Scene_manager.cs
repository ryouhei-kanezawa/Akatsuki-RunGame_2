using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum Scene_num
{
	Title = 0,
	Home,
	collection,
	Game
}

public class Scene_manager : MonoBehaviour
{
	[SerializeField]
	private bool set_change2 = true;
	[SerializeField]
	private Button change;
	[SerializeField]
	private Button change2;

	[SerializeField]
	private Scene_num num;
	[SerializeField]
	private Scene_num num2;

	private PlayBGM sound;

	private void Start()
	{
		change.onClick.AddListener(() => MoveScene((int)num));
		if (set_change2)
		{
			change2.onClick.AddListener(() => MoveScene((int)num2));
		}

		sound = GameObject.Find("soundSystem").GetComponent<PlayBGM>();
	}

	private void MoveScene(int num)
	{
		sound.PlayButton();
		SceneManager.LoadScene(num);
	}
}
