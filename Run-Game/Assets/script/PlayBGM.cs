using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
	[SerializeField]
	private AudioClip bgm;
	[SerializeField]
	private AudioClip button;

	private AudioSource audio;

	private void Start()
	{
		audio = GetComponent<AudioSource>();
	}

	private void PlaySoundBGM()
	{
		
	}
}
