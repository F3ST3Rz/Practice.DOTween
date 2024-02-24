using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;

    private MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        Tween tween = _renderer.material.DOColor(_targetColor, _duration);
        tween.SetLoops(-1, LoopType.Yoyo);
    }
}
