using UnityEngine;
using System.Collections;

public class LineMove : MonoBehaviour {
	bool upOrDown = true; //whether we are moving up or down
	bool stopped = false; //whether we have stopped or not
	int state = 0;
	public float upSpeed;    //our upwards movement speed
	public float downSpeed;    //our downwards movement speed
	public float maxHeight;    //the max height at which we will change direction
	public float minHeight;    //the min height at which we will change direction
	public float minWinHeight;    //the minimum height we must be at to win
	public float maxWinHeight;    //the maximum height we must be at to win
	public RectTransform tr;

	
	void Update() {
		switch (state) {
			case 0:
				//Default state is all stopped and resetted
				stopped = false;
				break;
			case 1:
				MoveUpDown();
				break;
		}
		
	}


	void MoveUpDown() {
		if (upOrDown) {    //if we are moving up
			tr.Translate(Vector3.up * upSpeed);    //move up
			if (tr.anchoredPosition.y > maxHeight) {    //if we are at the max height
				upOrDown = false;    //switch to moving down
			}
		}
		else {    //if we are moving down
			tr.Translate(Vector3.up * -downSpeed);    //move down
			if (tr.anchoredPosition.y < minHeight) {    //if we are at the min height
				upOrDown = true; //switch to moving up
			}
		}
	}

	public void setState(int _state) {
		state = _state;
	}

	public void setStopped(bool _stopped) {
		stopped = _stopped;
	}
}