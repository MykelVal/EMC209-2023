using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyPanel : MonoBehaviour
{
    public CurrencyManager _currencyManager;

    public TMP_Text _energyText;
    public TMP_Text _goldText;

    private void Start()
    {
        // Update the UI with the current currency balances
        UpdateCurrencyUI();
    }

    private void Update()
    {
        // Update the UI with the current currency balances
        UpdateCurrencyUI();
    }

    private void UpdateCurrencyUI()
    {
        // Update the UI with the current currency balances
        _energyText.text = "Energy: " + _currencyManager._egAmount.ToString();
        _goldText.text = "Money: " + _currencyManager._goAmount.ToString();
    }
}
