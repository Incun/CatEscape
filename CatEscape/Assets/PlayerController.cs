using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	GameObject player;
    
	void Start ()
	{
		this.player = GameObject.Find("player");
	}

	void Update()
	{
		// 왼쪽 화살표가 눌렸을 때
		if (Input.GetKey(KeyCode.LeftArrow) && this.player.transform.position.x >= -8 && GameDirector.instance.isgameover == false)
		{
			transform.Translate(-0.2f, 0, 0); // 왼쪽으로 [3] 움직인다.
		}

		// 오른쪽 화살표가 눌렸을 때
		if (Input.GetKey(KeyCode.RightArrow) && this.player.transform.position.x <= 8 && GameDirector.instance.isgameover == false)
		{
			transform.Translate(0.2f, 0, 0); // 오른쪽으로 [3] 움직인다.
		}
	}
}
