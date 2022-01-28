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
    private GameObject[] enemy;
    [SerializeField]
    private GameObject[] illust;
    [SerializeField]
    private int fieldNum = 20;
    [SerializeField]
    private int enemyNum = 20;
    [SerializeField]
    private float interval = 2f;
    [SerializeField]
    private float maxInterval = 0.2f;
    [SerializeField]
    private float localSpeed = 5f;
    [SerializeField]
    private float maxSpeed = 30f;
    [SerializeField]
    private float maxScore = 20000f;
    [SerializeField]
    private GameObject positionStone;
    [SerializeField]
    private GameObject positionSlopeTop;
    [SerializeField]
    private GameObject positionCoin;
    [SerializeField]
    private GameObject positionIllust;
    [SerializeField]
    private ScoreManager score;

    private GameUpdate swich = new GameUpdate();
    private static float speed;
    private float localIntarval;
    private float time;
    private Vector3 coinPos;
    private Vector3 slopePosTop;
    private Vector3 illustPos;
    private Vector3 stonePos;

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
        time = interval;
        localIntarval = interval;
        stonePos = positionStone.transform.position;
        slopePosTop = positionSlopeTop.transform.position;
        coinPos = positionCoin.transform.position;
        illustPos = positionIllust.transform.position;
        speed = localSpeed;
    }

	void Update()
    {
		if (!swich.GetBackSwich())
        {
            time += Time.deltaTime;
            if (interval <= time)
            {
                time = 0f;
                LocalInstantate();
            }
        }

		if (swich.GetGameSwich())
        {
            Ascent();
        }
    }

    private void Ascent()
    {

        if (interval <= maxInterval)
        {
            return;
        }

        interval -= (localIntarval + maxInterval) / (maxScore - score.Tmp);

        if (score.Tmp > maxScore)
		{
            return;
		}

        speed += (maxSpeed - localSpeed) / maxScore;
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
        bool fieldBool = false;

		if (!swich.GetBackSwich())
        {
            if (fieldPar >= fieldNum)
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
        }

		if (swich.GetGameSwich())
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
					}
                    break;

                case false: //通常・穴付き
                    var enemyPar = Random.Range(0, 100);

                    if (enemyPar >= enemyNum)
                    {
                        var num = Random.Range(0, 100);
                        var Enum = 80;
						if (num<=Enum)
						{
                            var instantObject = enemy[0];//石
                            Instantiate(instantObject, stonePos, Quaternion.identity);
						}
						else
						{
                            var instantObject = enemy[1];//おじさん
                            Instantiate(instantObject, stonePos, Quaternion.identity);
                        }
                    }
                    else
                    {
                        Cnum = Random.Range(0, item.Length);
						if (Cnum==0)
                        {
                            CreateIllust(illustPos);
						}
						else
                        {
                            var instantObject = item[Cnum];
                            Instantiate(instantObject, coinPos, Quaternion.identity);
                        }
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
