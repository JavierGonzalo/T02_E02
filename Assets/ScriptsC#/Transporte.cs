using UnityEngine;
using System.Collections;

public class Transporte : MonoBehaviour {
	
	// Vector3 es el tipo que hay que darle a una posicion (x, y, z)
	public Vector3 posicion;
	// La posicion del jugador
	public GameObject posicion_jugador;
	// la posicion final, 
	public GameObject posicion_final;
	
	
	void Start () {
		posicion = posicion_final.transform.position; 
	}
	
	void OnTriggerEnter(Collider collider)
	{
		posicion_jugador.transform.position = posicion; 
		
	}
}


