using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos
{
    public class userToken
    {
        [Key]  
        public int Id { get; set; }
      
        public string Token {get;set;}
    }
}