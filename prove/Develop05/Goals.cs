
public abstract class Goals{
   protected string _goalSet ;
    protected int _pointSet ;
    protected Boolean CheckedOff;
    public Goals(){
        CheckedOff =false;
    }

    public string GetGoal(){
        return _goalSet;
    }

    public void SetGoal(string goalSet){
        _goalSet = goalSet;
    }
    

    public virtual int GetPoints(){
        return _pointSet;

    }
    public void SetPoints(int pointSet){
        _pointSet = pointSet;
    }

public virtual void SetBonus(int _bonus){
    

}
public virtual void SettimesToComplete(int xtoComplete){

}
   public abstract int CheckOff();
   

   public void SetCheckedoff(Boolean x){

        CheckedOff = x;

   }
   public Boolean GetCheckedOff(){
    return CheckedOff;
   }
    
}

