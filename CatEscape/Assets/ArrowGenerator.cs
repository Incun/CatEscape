using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

	public GameObject player;

	public GameObject arrowPrefeb;
	float span = 1.2f;
	float delta = 0;

	void Start()
	{
		player = GameObject.Find("player");
	}

	void Update()
	{
		int Playerpx = Random.Range(1, 5); // 일정확률로 플레이어쪽으로 떨어지게
		float ArrowPositionpx = Random.Range(-1, 1);   // 플레이어 근처 범위
		delta += Time.deltaTime;
		if (this.delta > this.span && GameDirector.instance.isgameover == false)
		{
			if (Playerpx == 1)
			{
				this.delta = 0;
				GameObject go = Instantiate(arrowPrefeb) as GameObject;
				float pos = this.player.transform.position.x;
				pos += ArrowPositionpx;
				go.transform.position = new Vector3(pos, 7, 0);
			}
			else
			{
				this.delta = 0;
				GameObject go = Instantiate(arrowPrefeb) as GameObject;
				int px = Random.Range(-8, 8);
				go.transform.position = new Vector3(px, 7, 0);
			}
			if (this.span > 0.2f)
			{
				this.span = 0.53f;
			}
		}
	}
}