using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Enlarge : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    Vector3 CardScale;
    Vector3 CardLocation;

    void Start()
    {

        CardScale = transform.localScale;
        CardLocation = transform.localPosition;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
        transform.localPosition = new Vector3(10000f, 10000f, 10000f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        transform.localScale = CardScale;
        transform.localPosition = CardLocation;
    }
}
