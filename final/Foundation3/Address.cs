using System.Dynamic;

public class Address{

    string StreetName;
    private string City;
    private string state;


    public string GetStreetName(){
        return StreetName;
    }
    public void SetStreetName(string street){
        StreetName = street;

    }
     public string GetCity(){
        return City;
    }
    public void SetCity(string city){
       City = city;

    }
     public string GetState(){
        return state;
    }
    public void SetState(string _state){
        state = _state;

    }
    public string FullAddress(){
        return $"{StreetName} \n{City}, {state}"; 
    }
}