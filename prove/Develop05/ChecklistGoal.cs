
public class ChecklistGoal:Goals{
int bonus;
int timesToComplete;
public ChecklistGoal(){

       
}

    public override int CheckOff()
    {
        timesToComplete--;
        if(timesToComplete > 0){
            return _pointSet;
        }
        else{
            CheckedOff=true;
            return bonus +_pointSet;
            
        }
    }
    public override void SettimesToComplete(int xtoComplete){
        timesToComplete = xtoComplete;
    }

    public override void SetBonus(int _bonus){
    bonus = _bonus;

}

public override string ToString()
    {
       return $"ChecklistGoal: {_goalSet}, {_pointSet}, {bonus}, {CheckedOff}, {timesToComplete}";
    }
}
