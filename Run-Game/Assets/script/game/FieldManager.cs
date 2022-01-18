using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FieldManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] field;
    [SerializeField]
    private GameObject slope;
    [SerializeField]
    private GameObject[] item;
    [SerializeField]
    private GameObject[] illust;
    [SerializeField]
    private float interval = 2f;
    [SerializeField]
    private int fieldNum = 20;
    [SerializeField]
    private float localSpeed = 0.05f;
    [SerializeField]
    private float timeSpeed = 10f;
    [SerializeField]
    private float acceleration = 0.015f;
    [SerializeField]
    private GameObject positionItem;
    [SerializeField]
    private GameObject positionSlopeTop;
    [SerializeField]
    private GameObject positionSlopeUnder;
    [SerializeField]
    private GameObject positionIllust;
    [SerializeField]
    private TimeStart Stop;

    private static float speed;
    private float nextSpawnTime = 0;
    private Vector3 slopePosUnder;
    private Vector3 slopePosTop;
    private Vector3 illustPos;
    private Vector3 itemPos;

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

    private void Start()
	{
        itemPos = positionItem.transform.position;
        slopePosTop = positionSlopeTop.transform.position;
        slopePosUnder = positionSlopeUnder.transform.position;
        illustPos = positionIllust.transform.position;
        speed = localSpeed;
    }

	void Update()
    {
        if (nextSpawnTime < Time.timeSinceLevelLoad)
        {
            nextSpawnTime = Time.timeSinceLevelLoad + interval;
            LocalInstantate();
        }

		if (timeSpeed%Time.timeSinceLevelLoad<=0.0001f)
		{
            speed += acceleration;
            interval -= acceleration;
		}
    }

    public float Speed
	{
		get
		{
            return speed;
		}

		set
		{
            speed += value;
		}
	}

    private void LocalInstantate()
    {
        var fieldPar = Random.Range(0, 100);
        bool fieldBool;

		if (fieldPar>=fieldNum)
		{
            fieldBool = true;
            Instantiate(slope);
		}
		else
		{
            fieldBool = false;
            int Rnum = Random.Range(0, field.Length);
            Instantiate(field[Rnum]);
		}

		if (Stop.StopMoment())
		{
            int Cnum;

            switch (fieldBool)
			{
                case true: //スロープ
                    Cnum = Random.Range(0, item.Length);
					if (Cnum==0)
					{
                        CreateIllust(slopePosTop);
					}
					else
					{
                        var instantObject = item[Cnum];
						if (instantObject.CompareTag("coin"))
						{
                            Instantiate(instantObject, slopePosTop, Quaternion.identity);
						}
						else
						{
                            Instantiate(instantObject, slopePosUnder, Quaternion.identity);
                        }
					}
                    break;

                case false: //通常・穴付き
                    Cnum = Random.Range(0, item.Length);
                    if (Cnum == 0)
                    {
                        CreateIllust(illustPos);
                    }
                    else
                    {
                        Instantiate(item[Cnum], itemPos, Quaternion.identity);
                    }
                    break;
			}
		}
    }
    private void CreateIllust(Vector3 pos)
    {
        int rIllust = Random.Range(0, illust.Length);
        Instantiate(illust[rIllust], pos, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
