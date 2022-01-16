using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoadManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] field;
    [SerializeField]
    private GameObject slope;
    [SerializeField]
    private GameObject[] item;
    [SerializeField]
    private float interval = 2f;
    [SerializeField]
    private int fieldNum = 20;
    [SerializeField]
    private GameObject positionItem;
    [SerializeField]
    private GameObject positionSlopeTop;
    [SerializeField]
    private GameObject positionSlopeUnder;
    [SerializeField]
    private GameObject positionIllust;
    [SerializeField]
    private CollectionGame _illust;
    [SerializeField]
    private TimeStart Stop;

    private float nextSpawnTime = 0;
    private Vector3 slopePosUnder;
    private Vector3 slopePosTop;
    private Vector3 illustPos;
    private Vector3 itemPos;
    private bool fieldBool = true;

	private void Start()
	{
        itemPos = positionItem.transform.position;
        slopePosTop = positionSlopeTop.transform.position;
        slopePosUnder = positionSlopeUnder.transform.position;
        illustPos = positionIllust.transform.position;
    }

	void Update()
    {
        if (nextSpawnTime < Time.timeSinceLevelLoad)
        {
            nextSpawnTime = Time.timeSinceLevelLoad + interval;
            LocalInstantate();
        }
    }
    private void LocalInstantate()
    {
        var fieldPar = Random.Range(0, 100);
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
                        _illust.CreateIllust(slopePosTop);
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
                        _illust.CreateIllust(illustPos);
                    }
                    else
                    {
                        Instantiate(item[Cnum], itemPos, Quaternion.identity);
                    }
                    break;
			}
		}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
