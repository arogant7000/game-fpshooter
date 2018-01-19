using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PeluruMuncul : MonoBehaviour {
	public Rigidbody peluru;
	[Range(0,100)]
	public float speed = 60;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		// merespon setiap melakukan klik kiri pada mouse
		if (CrossPlatformInputManager.GetButtonDown("Fire1"))
		{	
			// menciptakan peluru dengan posisi tepat didpan pistol
			Rigidbody peluruBaru = (Rigidbody)GameObject.Instantiate(peluru, transform.position, transform.rotation);

			// melontarkan peluru kearah sumbuh y(vector3.up) dengan kecapatan yang telah ditentukan oleh variable speed
			peluruBaru.velocity = transform.TransformDirection(Vector3.forward * speed);

			// peluru akan hilang setalah 3 detik
			Destroy(peluruBaru.gameObject,3);
		}
	}
}