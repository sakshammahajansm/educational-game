using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stock : MonoBehaviour
{

    private int[] totstock = {100,50,75};
	public TextMeshProUGUI Text1;
	public TextMeshProUGUI Text2;
	public TextMeshProUGUI Text3;
    private int SelectedOption = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        SelectedOption = PlayerPrefs.GetInt("SelectedOption");
        totstock[SelectedOption] = totstock[SelectedOption]-1;
        Text1.text = totstock[0].ToString();
		Text2.text = totstock[1].ToString();
		Text3.text = totstock[2].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
