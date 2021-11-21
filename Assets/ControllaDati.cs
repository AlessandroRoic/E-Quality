using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllaDati : MonoBehaviour
{
    public void controllaDati() {
		if(GameManager.instance.getName() != "nomeTest" && GameManager.instance.getEta()!="Test" && GameManager.instance.getCitta() != "Test") {
			GameManager.instance.changeScene("SelezioneLivello");
		} else {
			Debug.Log("nome: " + GameManager.instance.getName());
			Debug.Log("eta: " + GameManager.instance.getEta());
			Debug.Log("citta: " + GameManager.instance.getCitta());
		}
	}
}
