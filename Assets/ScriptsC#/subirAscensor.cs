using UnityEngine;
using System.Collections;

public class subirAscensor : MonoBehaviour {

	[SerializeField]
	private GameObject ascensor; 
	private Animation subir_ascensor;  

	void Start()
	{
		ascensor = GameObject.Find ("Ascensor") as GameObject; 
		subir_ascensor = ascensor.GetComponent<Animation> (); 
	}

	void OnTriggerEnter(Collider collider) 
	{

		subir_ascensor.Play ("animacion_ascensor"); 
	}

}
