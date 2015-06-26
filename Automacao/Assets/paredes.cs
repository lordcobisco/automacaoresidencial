using UnityEngine;
using System.Collections;

public class paredes : MonoBehaviour {
//	public GameObject QuadroHabilitador;
	public GameObject parede;
	private bool flagParedePosicaoInicial = false;
	private Vector3 posicaoInicial;
	private Vector3 zeroTela;
	private GameObject paredeDesenhada;
	// Use this for initialization
	void Start () {
		zeroTela = new Vector3 (-8.0f, -3.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void CriaLevantaParede(){
		if (Input.GetMouseButton(0)) {
			if (!flagParedePosicaoInicial) {
				paredeDesenhada = Instantiate (parede) as GameObject;
				posicaoInicial = Input.mousePosition/80;
				paredeDesenhada.transform.position = posicaoInicial + zeroTela;
				flagParedePosicaoInicial = true;
			}
			if( paredeDesenhada)
				paredeDesenhada.transform.localScale = Input.mousePosition/80 - posicaoInicial;
		} else {
			flagParedePosicaoInicial = false;
		}
	}
}
