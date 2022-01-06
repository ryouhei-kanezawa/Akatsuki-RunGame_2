using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum distinction
{
    character1,
    character2,
    character3,
    character4,
    character5,
    character6,
    character7,
    character8,
    character9,
    character10,
    character11,
    character12,
    character13,
    character14,
    character15,
    character16,
    character17,
    character18,
    character19,
    character20,
    character21,
    character22,
    character23,
    character24,
    character25,
    character26,
    character27,
    character28,
    character29,
    character30,
    character31,
    character32,
    character33,
    character34,
    character35,
    character36,
    character37,
    character38,
    character39,
    character40,
    character41,
    character42,
    character43,
    character44,
    character45,
    character46,
    character47,
    character48,
    character49,
    character50,
}

public class CollectionIllust : MonoBehaviour
{
    [SerializeField]
    private distinction disIllust;
    [SerializeField]
    private float speed = 0.1f;
    [SerializeField]
    private GameObject boadbody;

    private Vector3 pos = new Vector3();

    private void Awake()
    {
        pos = boadbody.transform.position;
    }

    private void FixedUpdate()
    {
        pos.x -= speed;
        boadbody.transform.position = pos;
    }

    private string Sendenum()
	{
        return disIllust.ToString();
	}
}
