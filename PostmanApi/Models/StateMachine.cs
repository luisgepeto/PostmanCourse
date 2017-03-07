using System.Collections.Generic;

public class StateMachine{
    public StateMachine()
    {
        StateDictionary = new Dictionary<int, State>{
            {1, new State(1, "this is state 1", 3)},
            {2, new State(2, "this is the second state", 1)},
            {3, new State(3, "this is the last state", 2)}
        };
        CurrentStateId = 1;
    }
    public int CurrentStateId { get; set; }
    public State GetCurrentState(){
        return GetState(CurrentStateId);
    }
    
    public Dictionary<int, State> StateDictionary { get; set; }    
    public State GetNextState(){
        var nextStateId =  StateDictionary[CurrentStateId].NextStateId;            
        return GetState(nextStateId);
    }

    public State GetState(int stateId){
        if(StateDictionary.ContainsKey(stateId)){
            return StateDictionary[stateId];            
        }
        return null;
    }

}

public class State {
    public State(int stateId, string stateDescription, int nextStateId)
    {
        StateId = stateId;
        StateDescription = stateDescription;
        NextStateId = nextStateId;
    }
    public int StateId { get; set; }
    public string StateDescription { get; set; }
    public int NextStateId { get; set; }
}