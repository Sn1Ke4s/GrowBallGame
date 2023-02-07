using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIWinPanel : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Animation _animationPanel;

    private Action _onRestartButton;

    private void Start()
    {
        _restartButton.onClick.AddListener(OnRestartClicked);
        _animationPanel.Play();
    }

    private void OnRestartClicked()
    {
        _onRestartButton?.Invoke();
        SceneManager.LoadScene(0);
    }
}
