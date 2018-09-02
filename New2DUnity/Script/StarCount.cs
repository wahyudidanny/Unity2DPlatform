using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCount : MonoBehaviour {

	public static int countstars = 0;
	Text score;

	void Start () {
		score.GetComponent<Text>();
		score.text = "0/0";

	}
	

	void Update () {
		//Player.Stars += 1;
	}
}
