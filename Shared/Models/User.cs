namespace Shared.Models;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    
    public DateTime RegistrationDate { get; set; }
    public string Role { get; set; }
    
    public int GlobalScore { get; set; }
    public int QuizzesCompleted { get; set; }
    
    public List<Guid> CompletedQuizzes { get; set; }
    
    public bool IsOnline { get; set; }
}