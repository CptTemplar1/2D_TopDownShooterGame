﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBehavior : StateMachineBehaviour {

    private RedBossController boss;

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        boss = animator.GetComponent<RedBossController>();
        boss.isDead = true;
	}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}

	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}


}
