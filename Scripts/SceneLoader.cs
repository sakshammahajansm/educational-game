using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadNextScene(){
	int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	SceneManager.LoadScene(currentSceneIndex + 1);
	}

	public void LoadPreviousScene(){
	int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	if(currentSceneIndex>0){
		SceneManager.LoadScene(currentSceneIndex - 1);
	}
	}

   public void LoadStartScene(){
	SceneManager.LoadScene(0);

	}

	public void HomeSkip(){
	SceneManager.LoadScene(6);
	}

	public void MarketSkip(){
	SceneManager.LoadScene(9);
	}

	public void ShopSkip(){
	SceneManager.LoadScene(19);
	}

	public void QuitGame(){
		Application.Quit();
		Debug.Log("Quit!");
	}

}
