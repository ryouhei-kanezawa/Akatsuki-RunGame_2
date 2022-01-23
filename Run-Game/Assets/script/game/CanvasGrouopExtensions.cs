using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Murosta.Utility
{
    public static class CanvasGrouopExtensions
    {
        public static Tweener FadeOut(this Text text, float duration)
        {
            return text.DOFade(0.0F, duration);
        }

        public static Tweener FadeIn(this Text text, float duration)
        {
            return text.DOFade(1.0F, duration);
        }
    }
}