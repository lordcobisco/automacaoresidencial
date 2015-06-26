using UnityEngine;
using System.Collections;

public class ComportamentoObjetoClickOnOff : MonoBehaviour {
	public bool flagOnOff = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public bool getFlagOnOff(){
		return flagOnOff;
	}

	void OnMouseOver(){
		if (Input.GetMouseButton(0)) {
				if(!flagOnOff){
					flagOnOff = true;
				}
				else{
					flagOnOff = false;
				}
			}
	}
}
