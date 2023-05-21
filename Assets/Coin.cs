using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    [SerializeField] CoinData coinData;
    [SerializeField] Transform visual;
    [SerializeField] BaseAnimation baseAnimation;
    public int Value{ get => coinData.value; }

    private void Start()
    {
        visual.GetComponent<Renderer>().material = coinData.material;
        if (baseAnimation != null)
            baseAnimation.Animate(visual);
    }
}
