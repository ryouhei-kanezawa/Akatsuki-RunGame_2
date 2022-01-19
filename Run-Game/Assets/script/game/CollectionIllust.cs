using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionIllust : MonoBehaviour
{
    [SerializeField]
    private distinction dis_Illust;

    private Vector3 pos = new Vector3();
    private RectTransform illustPosition;
    private FieldManager _field;

    private void Start()
	{
        _field = GameObject.Find("break_area").GetComponent<FieldManager>();
        illustPosition = GetComponent<RectTransform>();
        pos = illustPosition.transform.position;
	}

	private void Update()
    {
		if (Time.timeScale!=0)
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
