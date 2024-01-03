using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour , IBeginDragHandler, IEndDragHandler, IDragHandler,IPointerDownHandler
{

   private Canvas canvas;
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void onBegindrag(PointerEventData eventData)
    {
        Debug.Log("onBegindrag");
    }
    void onEnddrag(PointerEventData eventData)
    {
        Debug.Log("onEnddrag");
    }
    void pointerDown(PointerEventData eventData)
    {
        Debug.Log("pointerDown");
    }
    public void onDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();

    }

   

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
