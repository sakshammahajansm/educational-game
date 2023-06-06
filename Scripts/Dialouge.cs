using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialouge : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines; 
    public float textSpeed;
    public int index; 

	public static Dialouge D;
    // Start is called before the first frame update
    void Start()
    {
       textComponent.text = string.Empty;
	 StartDialouge(); 
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetMouseButtonDown(0)){

		if(textComponent.text == lines[index]){
		NextLine();	
		}
		else{
	 		StopAllCoroutines();
		 	textComponent.text = lines[index];
		}
	
	
	}
	
        
    }



    void StartDialouge()
    {
	index = 0;
	//SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Dial[0]);
	StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
     
	foreach(char c in lines[index].ToCharArray()){
	 textComponent.text += c;
	 yield return new WaitForSeconds(textSpeed);
	}
    }

    void NextLine(){
	if(index < lines.Length -1){
	index++;
	textComponent.text = string.Empty;
	//SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Dial[index]);
	StartCoroutine(TypeLine());
	}
	else{
	gameObject.SetActive(false);
	int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	SceneManager.LoadScene(currentSceneIndex + 1);
	}

	}

}
