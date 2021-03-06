﻿/*
 * @Author: fasthro
 * @Date: 2019-09-21 16:25:16
 * @Description: Local Move Action (DoTween)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace FastEngine.Core
{
    public class DGLocalMoveAction : DGActionTransformBase
    {
        public DGLocalMoveAction(Transform transform, Vector3 startValue, Vector3 endValue, float duration, bool snapping = false)
         : base(transform, startValue, endValue, duration, snapping)
        {
        }

        protected override void OnInitialize()
        {
            if (m_tween == null)
            {
                m_tween = transform.DOLocalMove(m_eV3, m_duration, m_snapping).SetEase(m_ease).SetAutoKill(false);
                m_tween.OnComplete(() =>
                {
                    isCompleted = true;
                });
            }
        }

        protected override void OnRestoreValue()
        {
            transform.localPosition = m_sV3;
        }
    }
}
