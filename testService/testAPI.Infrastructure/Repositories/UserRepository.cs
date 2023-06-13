using Newtonsoft.Json.Linq;
using testAPI.Domain.Interfaces;
using testAPI.Domain.Models.ViewModels;

namespace testAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _baseUrl;
        public UserRepository(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public async Task<userViewModel> GetUsersData(int resultsQty)
        {
            var users = new userViewModel();
            try
            {
                using (HttpClient userRequest = new HttpClient())
                {
                    var response = await userRequest.GetStringAsync(_baseUrl + resultsQty);
                    var jsonResponse = JObject.Parse(response);

                    if (jsonResponse != null)
                    {
                        var res = jsonResponse["results"];

                        if (res != null)
                        {
                            List<results> userLst = new List<results>();
                            foreach (var item in res)
                            {
                                results user = new results();
                                user.gender = item["gender"].ToString();
                                user.name = item["name"].ToObject<name>();
                                user.location = item["location"].ToObject<location>();
                                user.email = item["email"].ToString();
                                user.dob = item["dob"].ToObject<dob>();
                                user.registered = item["registered"].ToObject<registered>();
                                user.phone = item["phone"].ToString();
                                user.cell = item["cell"].ToString();
                                user.id = item["id"].ToObject<id>();
                                user.picture = item["picture"].ToObject<picture>();
                                user.nat = item["nat"].ToString();

                                userLst.Add(user);
                            }
                            users.results = userLst.ToArray();
                        }
                        users.info = jsonResponse["info"].ToObject<info>();
                        return users;
                    }
                    else
                    {
                        Exception ex = new Exception("Error al obtener ususarios.");
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }
    }
}
