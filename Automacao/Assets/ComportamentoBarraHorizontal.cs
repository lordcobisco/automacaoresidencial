using UnityEngine;
using System.Collections;

public class ComportamentoBarraHorizontal : MonoBehaviour {
//	public GameObject QuadroHabilitador;
//	private bool HasChanged = false;
	private float LocalTime = 0.0f;
	public float velocidade = 8.0f, initialXValue = -0.02f, finalXValue = -3.0f, yValue = -0.48f, zValue = 1.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float xValue = (finalXValue - initialXValue) * (1f - Mathf.Exp (-LocalTime)) + initialXValue;
//		if (xValue > finalXValue)
//			xValue = finalXValue;
//		if (xValue > initialXValue)
//			xValue = initialXValue;

		this.transform.localPosition = new Vector3(xValue, yValue, zValue); 

		if((LocalTime <= 8 && velocidade > 0) || (LocalTime >= 0 && velocidade < 0))
			LocalTime += velocidade*Time.deltaTime;
	}

	public void deslizamento(){
		//if (QuadroHabilitador.GetComponent<ComportamentoObjetoClickOnOff> ().getFlagOnOff ()) {
			//if(HasChanged){
				velocidade = -velocidade;
			//	HasChanged = false;
			//}
		//} else {
			//if(!HasChanged){
			//	velocidade = -velocidade;
			//	HasChanged = true;
			//}
		//}
	}
}
