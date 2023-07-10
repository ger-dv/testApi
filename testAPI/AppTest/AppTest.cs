using testAPI.Domain.Models.InputModels;
using testAPI.Domain.Models.ViewModels;

namespace testAPI.AppTest
{
    public class AppTest
    {
        public AppTest() { }
        public float GetResult(input nums)
        {
            float res = nums.firstN + nums.secondN;
            return res;
        }
    }
}
