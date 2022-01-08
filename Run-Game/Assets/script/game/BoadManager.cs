using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoadManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] field;
    [SerializeField]
    private GameObject[] item;
    [SerializeField]
    private float interval = 2f;
    [SerializeField]
    private GameObject positionItem;
    [SerializeField]
    private GameObject positionSlope;
    [SerializeField]
    private GameObject positionIllust;
    [SerializeField]
    private CollectionGame _illust;
    [SerializeField]
    private TimeStart Stop;

    private float nextSpawnTime = 0;
    private Vector3 slopePos;
    private Vector3 illustPos;
    private Vector3 itemPos;

	private void Start()
	{
        itemPos = positionItem.transform.position;
        slopePos = positionSlope.transform.position;
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
        int Rnum = Random.Range(0, field.Length);
        GameObject opt = (GameObject)GameObject.Instantiate(field[Rnum]);

		if (Stop.StopMoment())
		{
            GameObject obj;
            int Cnum;

            switch (Rnum)
			{
                case 1: //穴付き床
                    Cnum = Random.Range(0, 1);
                    obj = Instantiate(item[Cnum], slopePos, Quaternion.identity);
                    break;

                case 2: //スロープ
                    Cnum = Random.Range(0, item.Length);
					if (Cnum==0)
					{
                        _illust.CreateIllust(slopePos);
					}
					else
					{
                        obj = Instantiate(item[Cnum], slopePos, Quaternion.identity);
					}
                    break;

				default://普通の床
			        Cnum = Random.Range(0, item.Length);
					if (Cnum==0)
					{
                        _illust.CreateIllust(illustPos);
					}
					else
					{
                        obj = Instantiate(item[Cnum], itemPos, Quaternion.identity);
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
