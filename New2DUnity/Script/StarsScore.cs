using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsScore : MonoBehaviour {

	public GameObject player;
	public Text dText;
	public string value;
	public int valuecountstar;

	void Start () {
	//	player = player.GetComponent<Player> ();
	}
	

	void Update () 
	{

	}


	public void TambahBintang(int value)
	{
		valuecountstar += value;
		dText.text =  (valuecountstar).ToString();
	}


}


