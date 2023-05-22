using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class CountDown : MonoBehaviour
{
    [SerializeField] int duration;

    public UnityEvent OnCountFinished = new UnityEvent();
    public UnityEvent<int> OnCount = new UnityEvent<int>();
    bool isCounting;
    Sequence seq;
    [SerializeField] bool test = false;

    private void OnEnable()
    {
        StartCoroutine(CountCoroutine());
    }

    public void StartCount()
    {
        StartCoroutine(CountCoroutine());
    }

    private IEnumerator CountCoroutine()
    {
        // yield return new WaitForSeconds(1);
        // yield return new WaitForEndOfFrame();
        Debug.Log(1);
        // yield return new WaitUntil(() => test);
        yield return new WaitWhile(() => test == false);
        Debug.Log(2);
        yield return new WaitForSecondsRealtime(1);
        Debug.Log(3);
    }

    // public void StartCount()
    // {
    //     if (isCounting == true)
    //         return;
    //     else
    //         isCounting = true;

    //     seq = DOTween.Sequence();

    //     OnCount.Invoke(duration);
    //     for (int i = duration - 1; i >= 0; i--)
    //     {
    //         var count = i;
    //         seq.Append(transform
    //             .DOMove(this.transform.position, 1)
    //             .SetUpdate(true)
    //             .OnComplete(() => OnCount.Invoke(count)));
    //     }

    //     seq.Append(transform
    //         .DOMove(this.transform.position, 1))
    //         .SetUpdate(true)
    //         .OnComplete(() =>
    //         {
    //             isCounting = false;
    //             OnCountFinished.Invoke();
    //         }
    //         );
    // }
}
