using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbjektaParadas : MonoBehaviour {
	public GameObject meitene1;
	public GameObject bluze1;
	public GameObject sorti1;
	public GameObject kurpes1;
	public GameObject bluze2;
	public GameObject kleita1;
	public GameObject kurpes2;
	public GameObject kleita2;
	public GameObject kurpes3;
	public GameObject krekle1;
	public GameObject sorti2;
	public GameObject kurpes4;

	public void meitena1Attelosana(bool vertiba) {
		meitene1.SetActive(vertiba);
	}
	public void bluzes1Attelosana(bool vertiba) {
		bluze1.SetActive(vertiba);
	}	
	public void sortas1Attelosana(bool vertiba) { 
		sorti1.SetActive(vertiba);
	}
	public void kurpes1Attelosana(bool vertiba) { 
		kurpes1.SetActive(vertiba);
	}
	public void bluzes2Attelosana(bool vertiba) {
		bluze2.SetActive (vertiba);
	}
	public void kleitas1Attelosana(bool vertiba){
		kleita1.SetActive (vertiba);
}
	public void kurpes2Attelosana(bool vertiba){
		kurpes2.SetActive (vertiba);
}
	public void kletas2Attelosana(bool vertiba){
		kleita2.SetActive (vertiba);
}
	public void kurpes3Attelosana(bool vertiba){
		kurpes3.SetActive (vertiba);
}
	public void krekla1Attelosana(bool vertiba){
		krekle1.SetActive (vertiba);
}
	public void  sorti2Attelosana(bool vertiba){
		sorti2.SetActive (vertiba);
	}
	public void kurpes4Attelosana(bool vertiba){
		kurpes4.SetActive (vertiba);
	}
}
