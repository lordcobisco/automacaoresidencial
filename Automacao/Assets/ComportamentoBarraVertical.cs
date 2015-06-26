using UnityEngine;
using System.Collections;

public class ComportamentoBarraVertical : MonoBehaviour {
//	public GameObject QuadroHabilitador;
//	private bool HasChanged = false;
	private float LocalTime = 0.0f;
	public float velocidade = 6.0f, initialYValue = 0.25f, finalYValue = 0.7f, xValue = -0.094f, zValue = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float yValue = (1f - Mathf.Exp (-LocalTime)) * (finalYValue - initialYValue) + initialYValue;
//		if (yValue > finalYValue)
//			yValue = finalYValue;
//		if (yValue > initialYValue)
//			yValue = initialYValue;

//		if (QuadroHabilitador.GetComponent<ComportamentoObjetoClickOnOff> ().getFlagOnOff ()) {
//			if(HasChanged){
//				velocidade = -velocidade;
//				HasChanged = false;
//			}
//		} else {
//			if(!HasChanged){
//				velocidade = -velocidade;
//				HasChanged = true;
//			}
//		}
		this.transform.localPosition = new Vector3( xValue, yValue, zValue); 

		if((LocalTime <= 5 && velocidade > 0) || (LocalTime >= 0 && velocidade < 0))
			LocalTime += velocidade*Time.deltaTime;
	}

	public void deslizamento(){
		velocidade = -velocidade;
	}
}
