using UnityEngine;
using System.Collections;

public class obtenerLlave : MonoBehaviour {

	[SerializeField]
	private GameObject player; 
	private GameObject llave; 
	private Inventario inventario;  

	void Start () 
	{
		player = GameObject.Find ("Player") as GameObject;
		llave = GameObject.Find ("GO_Llave") as GameObject; 
		inventario = player.GetComponent<Inventario> ();  
	
	}

	void OnTriggerEnter(Collider collider) 
	{
		inventario.llave = true; 
		Destroy (this.llave); 
		// Destroy(gameObject); 
	}


}
