/***
 *
 * @Author: Roman
 * @Created on: 23/12/2020
 *
 * @Copyright (c) by BorysProductions
 *
 ***/

using System;
using UnityEngine;

namespace ChristmasLogvillage
{
    public class AnimController : MonoBehaviour
    {
        public Animator animator;

        private void Awake()
        {
            if (!animator)
                animator = GetComponent<Animator>();
        }
    }
}