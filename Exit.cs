using UnityEngine;

class Exit : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
			Application.Quit();
	}
}