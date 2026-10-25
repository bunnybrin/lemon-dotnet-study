using CSharpFunctionalExtensions;
using Lemon.Domain.Shared;

namespace Lemon.Domain.Modules;

public class Module: Shared.Entity<ModuleId>
{
    public List<Issue> _issues = [];

    private Module(ModuleId id): base(id)
    {
    }

    private Module(ModuleId id, string title, string description): base(id)
    {
        Title = title;
        Description = description;
    }

    public static Result<Module> Create(ModuleId id, string title, string description)
    {
        if (string.IsNullOrWhiteSpace(title)) return Result.Failure<Module>("Title can not be empty");
        if (string.IsNullOrWhiteSpace(description)) return Result.Failure<Module>("Description can not be empty");

        var module = new Module(id, title, description);
        return Result.Success(module);
    }
    
    public string Title { get; private set; } = String.Empty;
    public string Description { get; private set; } = String.Empty;

    public IReadOnlyList<Issue> Issues => _issues;

    public int NumberOfIssues => Issues.Count;

    void AddIssue(Issue issue)
    {
        _issues.Add(issue);
    }
}