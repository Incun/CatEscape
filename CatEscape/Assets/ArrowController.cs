using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController   : MonoBehaviour {

	float speed = -0.1f;
	float px = 0;


	public GameObject player;

	public UICtrl uc;

	void Start()
	{
		this.player = GameObject.Find("player");
		uc = GameObject.Find("UIController").GetComponent<UICtrl>();
		px = Random.Range(1.001f, 1.02f);
	}

	void Update()
	{
		if(GameDirector.instance.isgameover == false)
		{
			// 프레임마다 낙하 속도를 증가시킨다.
			transform.Translate(0, this.speed, 0);
			this.speed *= px;

			// 화면 밖으로 나오면 오브젝트를 소멸시킨다.
			if (transform.position.y < -4.06f)
			{
				Destroy(gameObject);
			}

			// 충돌 판정
			Vector2 p1 = transform.position;                  //화살의 중심 좌표
			Vector2 p2 = this.player.transform.position;  //플레이어의 중심 좌표
			Vector2 dir = p1 - p2;
			float d = dir.magnitude;
			float r1 = 0.1f;       // 혁순이 반경
			float r2 = 1.0f;       // 플레이어 반경

			if (d < r1 + r2)
			{
				// 충돌하면 화살을 소멸시킨다.
				Destroy(gameObject);

				// 감독 스크립트에 플레이어와 화살이 충돌했다고 전달한다.
				uc.DecreaseHp();
			}
		}
	}
}