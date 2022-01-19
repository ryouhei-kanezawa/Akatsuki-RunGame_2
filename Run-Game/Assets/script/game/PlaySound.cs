using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
	[SerializeField]
	private AudioClip jumpEffect1;
	[SerializeField]
	private AudioClip jumpEffect2;
	[SerializeField]
	private AudioClip hitEffect;
	[SerializeField]
	private AudioClip coinEffect;

	private new AudioSource audio;

	private void Start()
	{
		audio = GetComponent<AudioSource>();
	}

	public void PlayJumpEffect()
	{
		var rand = Random.Range(1, 10);
		if (rand%2==0)
		{
			audio.PlayOneShot(jumpEffect2);
		}
		else
		{
			audio.PlayOneShot(jumpEffect1);
		}
	}

	public void PlayHitEffect()
	{
		audio.PlayOneShot(hitEffect);
	}

	public void PlayCoinEffect()
	{
		audio.PlayOneShot(coinEffect);
	}
}
