﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class I_totally_know_how_to_code_pro_programer_100 : MonoBehaviour
{
    public string mainWord = "default";
    public int livesCount = 10;
    public TextMeshProUGUI mainWordText;
    public TMP_InputField inputField;
    public TextMeshProUGUI LivesCountText;
    public TextMeshProUGUI messageText;
    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
        LivesCountText.text = $"zostało {livesCount} prób ";
    }

    public void OnClick()
    {
        Debug.Log($"Guzik został kliknięty");
        livesCount = livesCount - 1;
        LivesCountText.text = $"zostało {livesCount} prób ";

        if (mainWord == inputField.text)
        {
            messageText.text = $"Poprawne słowo zostało wpisane";
            return;

        }
        if (mainWord.Length != inputField.text.Length)
        {
            messageText.text = $"liczba lieter się nie zgadza";
            return;

        }

        int bullsCount = CountBulls();
        int cowsCount = CountCows();
        messageText.text = $" Bulls: {bullsCount} Cows:{cowsCount}";
    }

    public int CountBulls()
    {
        int result = 0;
        for (int i = 0; i < mainWord.Length; i++)
        {
            if (mainWord[i] == inputField.text[i])
            {
                result++;
            }
        }
        return result;
    }
    public int CountCows()
    {
        int result = 0;
        for (int i = 0; i < mainWord.Length; i++)
        {
            if (mainWord[i] != inputField.text[i] && mainWord.Contains(inputField.text[i]) )
                    {
                result++;
            }
           
        }
        return result;
    }
    // Update is called once per frame
    void Update()
    {

    }


 }    
    

