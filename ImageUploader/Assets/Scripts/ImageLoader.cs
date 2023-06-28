using UnityEngine ;
using System.Collections.Generic;

public class ImageLoader : MonoBehaviour 
{
    [SerializeField] private RectTransform _screenShow;
    [SerializeField] private List<ImageData> _imageData = new List<ImageData>();

    private void Awake()
    {
        LoadBlock();
    }

    private void LoadBlock()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _imageData.Add(transform.GetChild(i).GetComponent<ImageData>());
            _imageData[i].Id = i+1;
        }
    }

    private void Update()
    {
        for (int i = 0; i < _imageData.Count; i++)
        {
            if (IsVisible(i) && !_imageData[i].IsVisible)
            {
                _imageData[i].StartDownloadImage();
            }
        }
    }

    private bool IsVisible(int index)
    {
        RectTransform imageRectTransform = _imageData[index].GetComponent<RectTransform>();
        bool isVisible = RectTransformUtility.RectangleContainsScreenPoint(_screenShow, imageRectTransform.position);
        return isVisible;
    }
}