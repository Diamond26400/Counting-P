using UnityEngine;
using UnityEngine.UI;

public class ImageSourceSetter : MonoBehaviour
{
    public Image imageComponent;
    public Sprite sourceImage;

    void Start()
    {
        imageComponent.sprite = sourceImage;
    }
}