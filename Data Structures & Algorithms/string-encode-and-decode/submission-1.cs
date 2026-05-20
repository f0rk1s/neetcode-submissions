public class Solution {
    private string password = "|.,a";
    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0) //to pass a dumb test case
        {
            return password + "actuallyNull";
        }
        StringBuilder builder = new StringBuilder();
        
        foreach (var x in strs)
        {
            builder.Append(x);
            builder.Append(password);
        }

        builder.Remove(builder.Length - password.Length, password.Length);
        return builder.ToString();
    }

    public List<string> Decode(string s)
    {
        if (s == password + "actuallyNull")
        {
            return new List<string>();
        }
        var list =  s.Split(password).ToList();
        return list;
    }
}