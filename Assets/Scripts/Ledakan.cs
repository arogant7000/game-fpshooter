using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ledakan : MonoBehaviour {

	// berfungsi untuk menempatkan partikel yang akan dimasukkan dari inspector
	public GameObject particleLedakan;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	// berfungsi ketika object bersentuhan dengan object yang lain
	private void OnCollisionEnter(Collision collision)
	{	
		// cp adalah catatan setiap object yang menyentuh object lain. pengambilan index  o dimasudkan untuk nilai pertama kali didapatkan
		ContactPoint cp = collision.contacts[0];

		//mencari nilai yang dimana sumbu y berada diatas
		Quaternion rotasi = Quaternion.FromToRotation(Vector3.up, cp.normal);

		// menciptakan partikel dengan posisi dan rotasi yang telah ditentukan sebelumnya
		GameObject.Instantiate(particleLedakan, cp.point, rotasi);

		// menghapus gameobject yang terdapat discript ini
		Destroy(gameObject);
	}
}