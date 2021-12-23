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
    private TimeStart Stop;

    private float nextSpawnTime = 0;
    private int Rnum = 0;
    private int Cnum = 0;
    private Vector3 slopePos;
    private Vector3 itemPos;

	private void Start()
	{
        itemPos = positionItem.transform.position;
        slopePos = positionSlope.transform.position;
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
        Rnum = Random.Range(0, field.Length);
        GameObject opt = (GameObject)GameObject.Instantiate(field[Rnum]);

		if (Stop.StopMoment())
		{
            GameObject obj;

            switch (Rnum)
			{
                case 1: //穴付き床
                    Cnum = Random.Range(0, 1);
                    obj = (GameObject)GameObject.Instantiate(item[Cnum], slopePos, Quaternion.identity);
                    break;

                case 2: //スロープ
                    Cnum = Random.Range(0, item.Length);
                    obj = (GameObject)GameObject.Instantiate(item[Cnum],slopePos, Quaternion.identity);
                    break;

				default://普通の床
			        Cnum = Random.Range(0, item.Length);
                    obj = (GameObject)GameObject.Instantiate(item[Cnum], itemPos, Quaternion.identity);
					break;
			}
		}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
