using System.Dynamic;

public class Customer{
   private string name;
    private Address clientAddress;

     public Customer(string _name, Address address ) {
          name = _name;
          clientAddress = address;
     }

   public string GetName(){
        return name;
   }
   public void SetName(string Name){
        name = Name;
   }
   public bool USorNot(){
        return clientAddress.USorNot();
    
   }
          
    public Address GetAddress(){
     return clientAddress;
    }
     
}