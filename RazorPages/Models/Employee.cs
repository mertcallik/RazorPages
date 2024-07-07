namespace RazorPages.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Photo { get; set; } = string.Empty;
        public string Departmant { get; set; } = string.Empty;
    }
}
