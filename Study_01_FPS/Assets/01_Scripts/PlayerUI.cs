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
    private PlayerStat _stat;
   
    void Update()
    {
        UpdateHP();
    }

    private void UpdateHP()
    {
        _slider.value = _stat.CurHP / _stat.MaxHP;
        _text.text = $"HP : {_stat.CurHP} / { _stat.MaxHP}";
    }
}
