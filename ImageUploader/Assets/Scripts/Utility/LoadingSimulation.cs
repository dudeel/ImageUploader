using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadingSimulation : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Image _progressBar;

    private void Update()
    {
        int _currentText = (int)(_progressBar.fillAmount * 100);
        _text.SetText($"{_currentText}%");    
    }
}
