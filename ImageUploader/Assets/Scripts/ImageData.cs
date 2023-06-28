using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking ;
using System.Collections;

public class ImageData : MonoBehaviour
{
    [Header("Main Info")]
    public int Id;
    public bool IsVisible = false;
    [SerializeField] private RawImage Image;
    [SerializeField] private CurrentImage _currentImage;

    [Header("URL Images")]
    [SerializeField] private string _url = "http://data.ikppbb.com/test-task-unity-data/pics/";
    [SerializeField] private string _extension = ".jpg";

    public void StartDownloadImage()
    {
        IsVisible = true;
        StartCoroutine(GetImage());
    }

    private void SetImage(Texture2D _image)
    {
        if (Image) Image.texture = _image;
    }

    IEnumerator GetImage()
    {
        string _currentURL = _url + Id + _extension;
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(_currentURL);

        yield return request.SendWebRequest() ;

        if (request.isDone) SetImage(((DownloadHandlerTexture)request.downloadHandler).texture);
    }

    public void SelectImage()
    {
        _currentImage.CurrentID = Id;
    }
}
