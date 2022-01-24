using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionIllust : MonoBehaviour
{
    [SerializeField]
    private distinction dis_Illust;

    private Vector3 pos = new Vector3();
    private GameUpdate swich = new GameUpdate();
    private RectTransform illustPosition;
    private FieldManager _field;

    private void Start()
	{
        GameObject temp = GameObject.Find("break_area");
		if (temp!=null)
        {
            _field = temp.GetComponent<FieldManager>();
        }
        illustPosition = GetComponent<RectTransform>();
        pos = illustPosition.transform.position;
	}

	private void Update()
    {
		if (swich.GetGameSwich())
		{
            pos.x -= _field.Speed * Time.deltaTime;
            illustPosition.transform.position = pos;
		}
    }

    public distinction SendEnum()
	{
        return dis_Illust;
	}
}
