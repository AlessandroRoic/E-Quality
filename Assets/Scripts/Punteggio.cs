using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		GetComponent<Text>().text = "Punteggio: " + GameManager.instance.getPunteggio().ToString();
    }

}
