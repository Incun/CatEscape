using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
	public static GameDirector instance;

	
	public bool isgameover = false;

	private void Awake()
	{
		if(instance)
		{
			Destroy(instance);
		}
		instance = this;
	}

	private void Start()
	{
		isgameover = false;
	}
}
