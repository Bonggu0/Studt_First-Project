using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;
    [SerializeField]
    private TextMeshProUGUI _text;
    [SerializeField]
    private PlayerController _playerController;
    private PlayerStat _stat;

    private void Start()
    {
        _stat = _playerController.Stat;
    }
    private void OnEnable()
    {
        TrapObj.OnHPUpdate += UpdateHP;
    }
    private void OnDisable()
    {
        TrapObj.OnHPUpdate -= UpdateHP;
    }

    private void UpdateHP(int hp)
    {
        _stat.CurHP = -hp;
        UpdateUI();
    }

    private void UpdateUI()
    {
        _slider.value = _stat.CurHP / _stat.MaxHP;
        _text.text = $"HP : {_stat.CurHP} / {_stat.MaxHP}";
    }
}
