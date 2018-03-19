using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandlerScript : MonoBehaviour {
	
	public void showMenu(GameObject panel) {
		if (panel.activeSelf) {
			panel.SetActive (false);
		} else {
			panel.SetActive (true);		
		}
	}

	public void showDevelopedBy() {

	}

	public void showAboutUs() {

	}

}
