using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {

	[SerializeField]
	private bool _llave;

	public bool llave
	{
		set { this._llave = value; 
			Debug.Log(_llave);
		}
		//get the person name 
		get { return this._llave; }
	}

	public bool tienesLlave()
	{
		return llave; 
	}

	public void cogerLlave()
	{
		llave = true; 
	}

}
