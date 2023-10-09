namespace Isogram.app.Services
{
    public class RepetitiveCharService
    {
        public string answerYes = "Isogram";
        public string answerNo = "Not a Isogram";

        
        public string FindIfIsogram(string word)
        {
            word = word.ToLower();
            List<char> mylist = new();
            foreach(char c in word)
            {
                if(char.IsLetter(c))
                {
                    mylist.Add(c);                          
                }
            }
            IEnumerable<char> distinctChar = mylist.Distinct();

            if(distinctChar.Count() == mylist.Count())
            {
                return answerYes;
            }
            word = "";
            return answerNo;          
        }
    }
}