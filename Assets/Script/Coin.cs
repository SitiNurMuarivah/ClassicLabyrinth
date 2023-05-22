using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] CoinData coinData;
    [SerializeField] Transform visual;
    [SerializeField] BaseAnimation baseAnimation;

    // [SerializeField] TMP_Text scoreText;
    // private int scoreValue = 0;
    public int Value { get => coinData.value; }

    private void Start()
    {
        visual.GetComponent<Renderer>().material = coinData.material;
        if (baseAnimation != null)
            baseAnimation.Animate(visual);
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (collision.gameObject.tag == "Coin")
    //     {
    //         collision.gameObject.SetActive(false);
    //         scoreValue += 1;
    //         SetScore();
    //     }
    // }

    // void SetScore()
    // {
    //     scoreText.text = "COINS: " + scoreValue;
    // }
}
