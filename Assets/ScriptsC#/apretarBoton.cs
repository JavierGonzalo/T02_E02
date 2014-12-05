using UnityEngine;
using System.Collections;

public class apretarBoton : MonoBehaviour {

	[SerializeField]
	private GameObject boton; 
	private Animation animacion_boton; 

	//private GameObject player; 
	
	
	// Inicializamos el objeto
	void Start () 
	{
		//player = GameObject.Find ("player") as GameObject; 
		boton = GameObject.Find ("miBoton") as GameObject;
		animacion_boton = boton.GetComponent<Animation> ();
	}
	
	void OnTriggerEnter(Collider collider) 
	{ 
		animacion_boton.Play("animacion_boton");
	}
	



}
