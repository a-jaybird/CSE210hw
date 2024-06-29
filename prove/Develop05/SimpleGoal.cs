public class SimpleGoal: Goals {


public  SimpleGoal (){

}

    public override int CheckOff()
    {
       SetCheckedoff(true);
       return _pointSet;
    }

    public override string ToString()
    {
       return $"SimpleGoal: {_goalSet}, {_pointSet},{CheckedOff}";
    }

}