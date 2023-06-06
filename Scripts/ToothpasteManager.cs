using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToothpasteManager : MonoBehaviour
{
    public ToothpasteDB characterDB;
	public SpriteRenderer artworkSprite;
	private int SelectedOption = 0;

    void Start()
    {

	  if(PlayerPrefs.HasKey("SelectedOption")){
		Load();
		}
	  else{
		SelectedOption = 0;
		}
        updateCharacter(SelectedOption);
    }

	public void nextOption(){
		SelectedOption++;
		if(SelectedOption >= characterDB.characterCount){
			SelectedOption = 0;
		}

		updateCharacter(SelectedOption);
		Save();		
	}

	public void backOption(){
		SelectedOption--;
		if(SelectedOption < 0){
			SelectedOption = characterDB.characterCount - 1;
		}

		updateCharacter(SelectedOption);
		Save();		
	}


	private void updateCharacter(int SelectedOption){
		Toothpaste character = characterDB.getCharacter(SelectedOption);
		artworkSprite.sprite = character.toothpasteSprite;
	}

	private void Load(){
		SelectedOption = PlayerPrefs.GetInt("SelectedOption");
	}

	private void Save(){
		PlayerPrefs.SetInt("SelectedOption",SelectedOption);
	}

}
