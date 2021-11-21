using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PunteggioTiri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		string text = "";
		int[] tiri = GameManager.instance.getTiri();
		for(int i = 0; i < 3; i++) {
			text += "Tiro "+(i+1)+": "+tiri[i]+Environment.NewLine;
		}
		GetComponent<Text>().text = text;
    }
}
