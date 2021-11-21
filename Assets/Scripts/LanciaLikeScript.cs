using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LanciaLikeScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public rotateCannon rc;
	public LineMove lm;


	public void OnPointerDown(PointerEventData eventData) {
		lm.setStopped(false);
		rc.setRotationActive(false); //ferma la direzione
		lm.setState(1); //muovi la barra della potenza
		
	}

	public void OnPointerUp(PointerEventData eventData) {
		lm.setState(0);
		rc.fire((lm.tr.anchoredPosition.y / 4.7f));
		rc.setRotationActive(true);
	}

}
