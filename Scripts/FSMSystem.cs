using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMSystem
{
    private FSMState currentState;
    private List<FSMState> states = new List<FSMState>();
    private GameObject npc;
    // When we binding transition with statetype we only need to consider which transition to use instead of which state as result
    private Dictionary<Transition, StateType> transitionDictionary = new Dictionary<Transition, StateType>();

    public void AddTransition(Transition transition, StateType stateType)
    {
        // add transition and stateType params into transitionDictionary to To identify a transition
    }

    public void PerformTransition(Transition transition)
    {
        // find state in transitionDictionary by transition param
    }

    public FSMSystem(GameObject npc) { this.npc = npc; }
    public void InitState() { }

    // Update is called by Monobehavior script attached on npc
    void Update()
    {
        currentState.Reason();
        currentState.Act();
    }
}
