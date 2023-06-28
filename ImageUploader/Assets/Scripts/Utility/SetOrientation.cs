using UnityEngine;

public class SetOrientation : MonoBehaviour
{
    private enum typeOrientation
    {
        Portrait = 0,
        All = 1
    } 
    [SerializeField] private typeOrientation _selectOrientation;

    public void ChangeOrientation()
    {
        switch (_selectOrientation)
        {
            case typeOrientation.Portrait:
                Screen.orientation = ScreenOrientation.Portrait;
                break;
            case typeOrientation.All:
                Screen.orientation = ScreenOrientation.AutoRotation;
                break;
        }
    }
}
