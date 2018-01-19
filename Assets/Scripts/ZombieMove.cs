using UnityEngine;
using UnityEngine.SceneManagement;
public class ZombieMove : MonoBehaviour
{
	GameObject player;
	Animator animator;
	// Use this for initialization
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	// Update is called once per frame
	void Update()
	{
		transform.LookAt(player.transform);
		transform.Translate(Vector3.forward * Time.deltaTime * 20f);
	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag.Equals("Player"))
		{
			Destroy(gameObject);
			SceneManager.LoadScene("GameOver");
		}
		if (collision.gameObject.tag.Equals("Peluru"))
		{
			Data.score++;
			Destroy(gameObject);
		}
	}
}