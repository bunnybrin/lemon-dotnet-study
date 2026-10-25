namespace Lemon.Domain.Modules;

public class Issue
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    public Issue? ParentIssue { get; set; }

    public List<Issue> SubIssues { get; set; } = [];
    public List<File> Files { get; set; } = [];
}