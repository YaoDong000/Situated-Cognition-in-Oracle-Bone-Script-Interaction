using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QiaoGuShou : MonoBehaviour
{
	public GameObject QiaoGuShouZuo;
	public GameObject QiaoGuShouZhong;
	public GameObject QiaoGuShouYou;

	void Start()
	{
		QiaoGuShouZuo.SetActive(false);
		QiaoGuShouZhong.SetActive(false);
		QiaoGuShouYou.SetActive(false);
	}

	public void OnLoginButtonClickZuo()
	{
		QiaoGuShouZuo.SetActive(true);
	}
	public void OnLoginButtonClickZhong()
	{
		QiaoGuShouZhong.SetActive(true);
	}
	public void OnLoginButtonClickYou()
	{
		QiaoGuShouYou.SetActive(true);
	}
}
