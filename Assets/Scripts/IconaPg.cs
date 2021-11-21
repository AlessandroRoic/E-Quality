using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconaPg : MonoBehaviour
{
	public Sprite femmina;
	public Sprite maschio;
    // Start is called before the first frame update
    void Start()
    {
		if (GameManager.instance.getSesso()) {
			GetComponent<Image>().sprite = femmina;
		} else {
			GetComponent<Image>().sprite = maschio;
		}
    }

}
