using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchGallery : MonoBehaviour
{
	[SerializeField]
	private Button push_Illust;
	[SerializeField]
	private int num_illust;
	[SerializeField]
	private GameObject character_illust;

	CollectionGallery _gallery = new CollectionGallery();
	private Vector3 posIllust = new Vector3(0, 0, 5);
	GameObject kob = new GameObject();

	private void Reset()
	{
		push_Illust = GetComponent<Button>();
	}

	private void Start()
	{
		if (_gallery.GetGet_character(num_illust))
		{
			push_Illust.interactable = true;
			push_Illust.onClick.AddListener(() => AppearIllust());
		}
		else
		{
			push_Illust.interactable = false;
			ColorBlock cb = push_Illust.colors;
			cb.disabledColor = Color.black;
			push_Illust.colors = cb;
		}
	}

	private void AppearIllust()
	{
		kob = Instantiate(character_illust);
		kob.transform.position = posIllust;
		kob.transform.localScale = Vector3.one * 1;
	}
}