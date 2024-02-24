using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;

    private void Start()
    {
        int numberRepeat = 2;
        float delayColorChange = _duration * numberRepeat;
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("How are you?", _duration));
        sequence.Append(_text.DOText("\nIm fine.", _duration).SetRelative());
        sequence.Append(_text.DOText("it's a joke. I do not care.", _duration, true, ScrambleMode.All));
        sequence.Insert(delayColorChange, _text.DOColor(_targetColor, _duration));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
