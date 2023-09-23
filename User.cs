namespace UnsafeCode_TeamPlay
{
    public class User
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string COfB { get; set; }
        public string CurRes { get; set; }
        public string PrevRes { get; set; }
        public string Language { get; set; }

        public User(string Name, int Age, string COfB, string CurRes, string PrevRes, string Language) {
            this.Name = Name;
            this.Age = Age;
            this.COfB = COfB;
            this.CurRes = CurRes;
            this.PrevRes = PrevRes;
            this.Language = Language;
        }

        public override string ToString() { return $"Name: {Name}\nAge: {Age}\nCountry of Birthday: {COfB}\nLanguage: {Language}\nCurrent Residence: {CurRes}\nPrevious Residence: {PrevRes}  "; }
        public string ToStringAdditionalInfo() { return $"Language: {Language}\nCurrent Residence: {CurRes}\nPrevious Residence: {PrevRes}  "; }
        public string ToStringBaseInfo() { return $"Name: {Name}\nAge: {Age}\nCountry of Birthday: {COfB}";  }
    }
}
