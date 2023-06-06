using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;
	public SpriteRenderer artworkSprite;
	private int selectedOption = 0;
	private string input;
    void Start()
    {

	  if(PlayerPrefs.HasKey("selectedOption")){
		Load();
		}
	  else{
		selectedOption = 0;
		}
        updateCharacter(selectedOption);
    }

	public void nextOption(){
		selectedOption++;
		if(selectedOption >= characterDB.characterCount){
			selectedOption = 0;
		}

		updateCharacter(selectedOption);
		Save();		
	}

	public void backOption(){
		selectedOption--;
		if(selectedOption < 0){
			selectedOption = characterDB.characterCount - 1;
		}

		updateCharacter(selectedOption);
		Save();		
	}


	private void updateCharacter(int selectedOption){
		Character character = characterDB.getCharacter(selectedOption);
		artworkSprite.sprite = character.characterSprite;
	}

	private void Load(){
		selectedOption = PlayerPrefs.GetInt("selectedOption");
	}

	private void Save(){
		PlayerPrefs.SetInt("selectedOption",selectedOption);
	}

	public void changeScene(int sceneID){
		SceneManager.LoadScene(sceneID);
	}

	public void ReadStringInput(string s){
		input =s;
		Debug.Log(input);
	}
}
