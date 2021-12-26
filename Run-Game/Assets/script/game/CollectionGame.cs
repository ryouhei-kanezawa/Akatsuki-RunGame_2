using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CollectionGame : MonoBehaviour
{
    [SerializeField]
    private GameObject[] illust;

	private int rIllust = 0;

	private void Reset()
	{
		var guids_prefab = AssetDatabase
			.FindAssets("t:prefab", new string[] { "Assets/prefab/picture" });
		illust = new GameObject[guids_prefab.Length];

		for (int i = 0; i < guids_prefab.Length; i++)
		{
			string path_prefab = AssetDatabase.GUIDToAssetPath(guids_prefab[i]);
			illust[i] = AssetDatabase.LoadAssetAtPath<GameObject>(path_prefab);
		}
	}

	public void CreateIllust(Vector3 pos)
	{
		rIllust = Random.Range(0, illust.Length);
		GameObject opt = (GameObject)GameObject.Instantiate(illust[rIllust],pos, Quaternion.identity);
	}
}
