using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour 
{
	public GameObject canvas;
	void OnTriggerEnter(Collider other)
	{
		canvas.SetActive(true);
	}

	public void ChangeScene()
    {
		SceneManager.LoadScene(1);
	}
}
