using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICtrl : MonoBehaviour
{
	public Image hpGage;
	public GameObject gameOverPanel;

	private void Start()
	{
		hpGage = GameObject.Find("hpGage").GetComponent<Image>();
	}

	private void Update()
	{
		if (hpGage.fillAmount == 0 && GameDirector.instance.isgameover == false)
		{
			Time.timeScale = 0;
			gameOverPanel.SetActive(true);
			GameDirector.instance.isgameover = true;
		}
	}

	public void DecreaseHp()
	{
		hpGage.fillAmount -= 0.25f; //Hp 감소
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
