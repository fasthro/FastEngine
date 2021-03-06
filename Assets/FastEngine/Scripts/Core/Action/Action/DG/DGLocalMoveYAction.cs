/*
 * @Author: fasthro
 * @Date: 2019-09-24 15:36:30
 * @Description: Local Move Y Action (DoTween)
 */
using DG.Tweening;
using UnityEngine;

namespace FastEngine.Core
{
    public class DGLocalMoveYAction : DGActionTransformBase
    {
        public DGLocalMoveYAction(Transform transform, float startValue, float endValue, float duration, bool snapping = false)
        : base(transform, startValue, endValue, duration, snapping)
        {
        }

        protected override void OnInitialize()
        {
            if (m_tween == null)
            {
                m_tween = transform.DOLocalMoveY(m_eVF, m_duration, m_snapping).SetEase(m_ease).SetAutoKill(false);
                m_tween.OnComplete(() =>
                {
                    isCompleted = true;
                });
            }
        }

        protected override void OnRestoreValue()
        {
            // TODO
        }
    }
}