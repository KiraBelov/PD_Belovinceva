using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbjektaParadas : MonoBehaviour {
	public GameObject meitene1;
	public GameObject bluze1;
	public GameObject sorti1;
	public GameObject kurpes1;

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
	}

