using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class WinBehavior : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private TextMeshProUGUI _winText; // reference to the win text
    [SerializeField] private TextMeshProUGUI _loseText;

    [SerializeField] private CurrencyManager _currencyManager;

    private bool hasWon = false; // flag to keep track of whether the player has won or not


    void Start()
    {
        _winPanel.SetActive(false); // disable the win panel at the beginning
    }

    void Update()
    {
             
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasWon && collision.gameObject.GetComponent<PhotonView>().IsMine) // check if the player has reached the goal
            Win(); // if so, call the Win() function
        else
        {
            Lose();
        }
    }

    void Win()
    {
        hasWon = true; // set the flag to true
        _winPanel.SetActive(true); // enable the win text
        _winText.text = "Player " + PhotonNetwork.LocalPlayer.NickName + " has won!"; // set the win text to display the player number
        PhotonView.Get(this).RPC("ShowWinText", RpcTarget.Others); // call the ShowWinText() function on all other players
        _currencyManager.AddCurrency(CurrencyManager.VirtualCurrency.GO, 500);
    }

    void Lose()
    {
        _loseText.text = "You Lost!";
        _currencyManager.SubtractCurrency(CurrencyManager.VirtualCurrency.EG, 1);
    }

    [PunRPC]
    void ShowWinText()
    {
        Lose();
    }
}