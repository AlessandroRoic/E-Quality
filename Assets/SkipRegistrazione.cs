using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipRegistrazione : MonoBehaviour
{
    public void skip() {
		if(GameManager.instance.getName() != "nomeTest") {
			GameManager.instance.changeScene("SelezioneLivello");
		} else {
			GameManager.instance.changeScene("Registrazione");
		}
	}
}
