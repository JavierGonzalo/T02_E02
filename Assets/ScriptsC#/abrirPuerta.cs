using UnityEngine;
using System.Collections;

public class abrirPuerta : MonoBehaviour {
	// Con Serializefield podemos acceder a variables de un objeto desde fuera
	[SerializeField]
	private GameObject puerta; 
	private Animation animacion_puerta; 

	private GameObject player; 
	private Inventario inventario; 


	// Inicializamos el objeto
	void Start () 
	{
		animacion_puerta = puerta.GetComponent<Animation> ();
		player = GameObject.Find ("Player") as GameObject;
		inventario = player.GetComponent<Inventario> ();  
	}

	void OnTriggerEnter(Collider collider) 
	{
		if (inventario.llave) 
		{
			animacion_puerta.Play ("animacion_puerta");
		}

	}

	void OnTriggerExit(Collider collider)
	{
		if (inventario.llave)
		{
			animacion_puerta.Play ("cerrar_puerta"); 
		}

	}

	

}
