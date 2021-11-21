using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class moveTermometro : MonoBehaviour
{
   void Update() {
		this.GetComponent<Scrollbar>().value = GameManager.instance.getFelicita();
	}
}
