namespace testAPI.Domain.Models.ViewModels
{
    public class userViewModel
    {
        public results[]? results {  get; set; }
        public info? info { get; set; }
    }
    public class results
    {
        public string? gender { get; set; }
        public name? name { get; set; }
        public location? location { get; set; }
        public string? email { get; set; }
        public dob? dob { get; set; }
        public registered? registered { get; set; }
        public string? phone { get; set; }
        public string? cell { get; set; }
        public id? id { get; set; }
        public picture? picture { get; set; }
        public string? nat { get; set; }
    }
    public class info
    {
        public string? seed { get; set; }
        public int results { get; set; }
        public int page { get; set; }
        public string? version { get; set; }
    }
    public class name
    {
        public string? title { get; set; }
        public string? first { get; set; }
        public string? last { get; set; }
    }
    public class location
    {
        public street? street {get; set;}
        public string? city { get; set;}
        public string? state { get; set;}
        public string? country { get; set;}
        public int postcode { get; set;}
        public coordinates? coordinates { get; set;}
        public timezone? timezone { get; set;}
    }
    public class street
    {
        public int number { get; set; }
        public string? name { get; set; }
    }
    public class coordinates
    {
        public string? latitude { get; set; }
        public string? longitude { get; set; }
    }
    public class timezone
    {
        public string? offset { get; set; }
        public string? description { get; set; }
    }
    public class dob
    {
        public string? date { get; set; }
        public int age { get; set; }
    }
    public class registered
    {
        public string? date { get; set; }
        public int age { get; set; }
    }

    public class id
    {
        public string? name { get; set; }
        public string? value { get; set; }
    }
    public class picture
    {
        public string? large { get; set; }
        public string? medium { get; set; }
        public string? thumbnail { get; set; }
    }
}
