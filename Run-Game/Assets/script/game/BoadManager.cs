using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoadManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] firld;
    [SerializeField]
    private GameObject[] item;
    [SerializeField]
    private float interval = 2f;
    [SerializeField]
    private float cval = 1.5f;
    [SerializeField]
    private TimeStart Stop;

    private float nextSpawnTime = 0;
    private float nextSpawnItem = 0;
    private int Rnum = 0;
    private int Cnum = 0;

    void Update()
    {
        if (nextSpawnTime < Time.timeSinceLevelLoad)
        {
            nextSpawnTime = Time.timeSinceLevelLoad + interval;
            LocalInstantate();
        }

        if (nextSpawnItem < Time.timeSinceLevelLoad&&Stop.StopMoment())
        {
            nextSpawnItem = Time.timeSinceLevelLoad + cval;
            ItemInstantate();
        }
    }
    private void LocalInstantate()
    {
        Rnum = Random.Range(0, firld.Length);
        GameObject opt = (GameObject)GameObject.Instantiate(firld[Rnum]);
    }

    private void ItemInstantate()
	{
        Cnum = Random.Range(0, item.Length);
        GameObject obj = (GameObject)GameObject.Instantiate(item[Cnum]);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }

	public void CleanBoadObject()
    {
        GameObject[] boads = GameObject.FindGameObjectsWithTag("field");

        foreach(var VARIABLE in boads)
        {
            Destroy(VARIABLE);
        }
    }
}
