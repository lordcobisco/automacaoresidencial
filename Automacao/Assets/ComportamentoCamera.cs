using UnityEngine;
using System.Collections;

public class ComportamentoCamera : MonoBehaviour {
	private double LocalTime;
	public bool flagPosicaoCamera = true;
	private int cont = 0; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void MudarVisualizacaoInternaExterna(){
		if (Input.GetMouseButtonDown(0)) {

			if(cont >= 1  &  LocalTime < 0.8f & flagPosicaoCamera){
				this.transform.position = new Vector3(0,0,1f);
				this.transform.eulerAngles = new Vector3(0,0,90);
				flagPosicaoCamera = false;
			}
			else if(cont >= 1 &  LocalTime < 0.8f){
				this.transform.position = new Vector3(0,0,-10f);
				this.transform.eulerAngles = new Vector3(0,0,0);
				flagPosicaoCamera = true;
			}
			cont++;
		}
		LocalTime += Time.deltaTime;
		if (LocalTime > 0.8f) {
			cont = 0;
			LocalTime = 0;
		}
	}
}
