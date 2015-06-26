using UnityEngine;
using System.Collections;

public class ComportamentoParede : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.transform.position = new Vector2(Mathf.Round(this.transform.position.x), Mathf.Round(this.transform.position.y));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
