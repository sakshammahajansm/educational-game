using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

      public CharacterDatabase characterDB;
	public SpriteRenderer artworkSprite;
	private int selectedOption = 0;
    // Start is called before the first frame update
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


	private void updateCharacter(int selectedOption){
		Character character = characterDB.getCharacter(selectedOption);
		artworkSprite.sprite = character.characterSprite;
	}

	private void Load(){
		selectedOption = PlayerPrefs.GetInt("selectedOption");
	}

}
