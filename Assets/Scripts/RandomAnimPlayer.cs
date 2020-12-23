/***
 *
 * @Author: Roman
 * @Created on: 23/12/2020
 *
 * @Copyright (c) by BorysProductions
 *
 ***/

using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomAnimPlayer : MonoBehaviour
{
    public List<AnimSet> animationSets;
    public Animator[] animators;
    
    #region ## Unity Methods ##

    private void Awake()
    {
        if (animators.Length == 0)
            animators = GetComponentsInChildren<Animator>();
    }
    
    
    void Start()
    {
        
    }
    
    #endregion
    
    #region ## Core ##

    private void PlayAnimations()
    {
        if(animators.Length == 0) return;

        for (int i = 0; i < animators.Length; i++)
        {
            Random.InitState(Random.Range(100000, 100000000));
            var rand = Random.Range(0, animationSets.Count);

            animators[i].avatar = animationSets[rand].avatar;
            animators[i].runtimeAnimatorController = animationSets[rand].animatorController;
        }
    }
    
    #endregion
}

[Serializable]
public class AnimSet
{
    public Avatar avatar;
    public RuntimeAnimatorController animatorController;
}
