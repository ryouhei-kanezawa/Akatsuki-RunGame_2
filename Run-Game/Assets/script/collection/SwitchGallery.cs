using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchGallery : MonoBehaviour
{
	[SerializeField]
	private Button appear_illust;
	[SerializeField]
	private GameObject character_illust;

	CollectionGallery _gallery = new CollectionGallery();

	private void Reset()
	{
		appear_illust = GetComponent<Button>();
	}

	private void Start()
	{
		if (!_gallery.GetGet_character(1))
		{

		}
		else
		{

		}
	}
}
