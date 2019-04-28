namespace FriendLetter.Models //anyother file that needs to access model's logic can import it with "using FriendLetter.Models;"
{
  public class LetterVariable
  {
    //property to our class. As the property is private(encapsulated) we need a getter method to retrieve it
    private string _recipient;
    private string _sender;
    //Method to retrieve _recipient property(same method we refered in our Razor template)
    public string GetRecipient()
    {
      return _recipient;
    }
    //Setter Method for _recipient property so we can change whose name it displays.
    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }
    public void SetSender(string newSender)
    {
      _sender = newSender;
    }
  }
}
